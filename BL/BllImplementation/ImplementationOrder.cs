using BlApi;
using BO;
using System;
using System.Data;
using static BO.Tools;

namespace BllImplementation;

internal class ImplementationOrder : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    private ImplementationProduct implementationProduct = new ImplementationProduct();


    //return all relevant sales for this product
    public void SearchSaleForProduct(BO.ProductInOrder product, bool IsPreferredCustomer)
    {
        try
        {
            product.SalesInProducts = [.. _dal.Sale.ReadAll(sale => sale.id == product.ProductId && 
                                        (sale.isNeedClub == false || IsPreferredCustomer) && 
                                        sale.minimumAmount <= product.ProductAmount && 
                                        DateTime.Now >= sale.beginSale && DateTime.Now <= sale.endSale)
        .Select(s => s!.CastSale().CastFromSaleToSaleInOrder())
        .OrderBy(s => s.Price / s.Amount)];
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }


    }

    public void CalcTotalPriceForProduct(BO.ProductInOrder? product)
    {
        try
        {
            double? sum = 0;
            int? count = product.ProductAmount;
            foreach (BO.SaleInProduct sale in product.SalesInProducts)
            {
                if (count == 0)
                    break;
                while (count >= sale.Amount)
                {
                    sum += sale.Price;
                    count -= sale.Amount;
                }

            }
            sum += count * product.ProductBasePrice;
            product.TotalSum = sum;
        }
        catch (Exception e) { throw e; }
    }

    //calc the total sum of this order
    public void CalcTotalPrice(BO.Order order)
    {
        try
        {
            double? total = 0;
            foreach (BO.ProductInOrder product in order.ProductsInOrder)
            {
                total += product.TotalSum;

            }
            order.Price = total;
        }
        catch (Exception e) { throw e; }
    }


    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int amount)
    {
        try
        {
            
            if (order == null)
                throw new BlIsNotOption("ERROR! \t invalid input");
            DO.Product p = _dal.Product.Read(productId);
            BO.ProductInOrder product = order.ProductsInOrder?.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {

                if (p.amount >= amount + product.ProductAmount)
                    product.ProductAmount = amount + product.ProductAmount;
                else
                    throw new BlNotEnugh("There are not enough in stock");
            }
            else
            {
                product = CastProductToProductInOrder(p,amount);
                product.ProductAmount = amount;
                if (p.amount >= amount)
                    order.ProductsInOrder?.Add(product);
                else
                    throw new BlNotEnugh("There are not enough in stock");
            }
            SearchSaleForProduct(product, order.PreferredCustomer);
            CalcTotalPriceForProduct(product);
            CalcTotalPrice(order);
            return product.SalesInProducts;
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    //get an order and do it
    public void DoOrder(BO.Order order)
    {
        try
        {
            foreach (ProductInOrder prod in order.ProductsInOrder!)
            {
                BO.Product product = _dal.Product.Read(prod.ProductId)!.CastProduct();
                product.Amount -= prod.ProductAmount;
                _dal.Product.Update(CastProduct(product));
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}

