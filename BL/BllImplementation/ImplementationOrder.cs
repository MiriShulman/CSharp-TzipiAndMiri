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
    public void SearchSaleForProduct(BO.ProductInOrder? product, bool IsPreferredCustomer)
    {
        try
        {
            if (IsPreferredCustomer)
            {
                product.SalesInProducts = (from sale in _dal.Sale.ReadAll()
                                         where sale.code == product.ProductId &&
                                         sale.beginSale < DateTime.Now && sale.endSale > DateTime.Now
                                         && product.ProductAmount >= sale.minimumAmount
                                         orderby sale.minimumAmount / sale.sum
                                         select sale.CastSaleToSaleInProduct()).ToList();
                product.SalesInProducts = product.SalesInProducts.Count > 0 ? product.SalesInProducts : new List<SaleInProduct>();

            }
            else
            {
                product.SalesInProducts = (from sale in _dal.Sale.ReadAll()
                                         where sale.id == product.ProductId &&
                                         sale.beginSale > DateTime.Now && sale.endSale < DateTime.Now
                                         && product.ProductAmount >= sale.minimumAmount
                                         && sale.isNeedClub == false
                                         orderby sale.minimumAmount / sale.sum
                                         select sale.CastSaleToSaleInProduct()).ToList();
            }
        }
        catch (Exception ex) { throw ex; }

    }
    //calc the total price of this product
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
                //CalcTotalPriceForProduct(product);
                //if (total != null)
                //    total += product.ProductBasePrice;
            }
            order.Price = total;
        }
        catch (Exception e) { throw e; }
    }


    //return list of sales that add in this product's add

    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int amount)
    {
        BO.ProductInOrder p;
        try
        {
            DO.Product product = _dal.Product.Read(productId);
            if (order.ProductsInOrder == null)
            {
                if (amount <= product.amount)
                {
                    order.ProductsInOrder = new List<ProductInOrder>();
                    order.ProductsInOrder.Add(CastProductToProductInOrder(product, amount));
                    implementationProduct.Update(new Product(product.identity, product.name, product.price, product.amount - amount, CastCategory(product.c)));
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                p = order.ProductsInOrder.FirstOrDefault(p => p.ProductId == productId);
                if (p != null)
                {
                    if (p.ProductAmount + amount <= product.amount)
                    {
                        p.ProductAmount += amount;
                    }
                    else
                        throw new Exception("e");
                }
            }
            p = order.ProductsInOrder.FirstOrDefault(p => p.ProductId == productId);
            
            SearchSaleForProduct(p, order.PreferredCustomer);
            CalcTotalPriceForProduct(p);
            CalcTotalPrice(order);
            return p.SalesInProducts;

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

