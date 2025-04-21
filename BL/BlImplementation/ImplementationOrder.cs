using BlApi;
using BO;
using System;
using static BO.Tools;

internal class ImplementationOrder 
{
    private DalApi.IDal _dal = DalApi.Factory.Get;


    //return all relevant sales for this product
       public void SearchSaleForProduct(BO.ProductInOrder product, bool IsPreferredCustomer)
    {
        try
        {
            if (IsPreferredCustomer)
            {
                product.SalesInProducts = (from sale in _dal.sale.ReadAll()
                                         where sale.code == product.ProductId &&
                                         sale.beginSale > DateTime.Now && sale.endSale < DateTime.Now
                                         && product.ProductAmount >= sale.minimumAmount
                                         orderby sale.minimumAmount / sale.sum
                                         select sale.CastSaleToSaleInProduct()).ToList();
            }
            else
            {
                product.SalesInProducts = (from sale in _dal.sale.ReadAll()
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
    void CalcTotalPriceForProduct(BO.ProductInOrder product)
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
    void CalcTotalPrice(BO.Order order)
    {
        try
        {
            double? total = 0;
            foreach (BO.ProductInOrder product in order.ProductsInOrder)
            {
                CalcTotalPriceForProduct(product);
                if (total != null)
                    total += product.ProductBasePrice;
            }
            order.Price = total;
        }
        catch (Exception e) { throw e; }
    }


    //return list of sales that add in this product's add

    List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int ProductId, int amount)
    {
        try
        {
            DO.Product product = _dal.product.Read(ProductId);
            BO.ProductInOrder p = order.ProductsInOrder.FirstOrDefault(p => p.ProductId == ProductId);
            if (p != null)
            {
                if (p.ProductAmount + amount <= product.amount)
                {
                    p.ProductAmount += amount;
                }
                else
                    throw new Exception("e");
            }
            else
            {
                if (amount <= product.amount)
                {
                    order.ProductsInOrder.Add(CastProductToProductInOrder(product));
                }
                else
                {
                    throw new Exception();
                }
            }
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
    void DoOrder(BO.Order order)
    {
        try
        {
            foreach (ProductInOrder prod in order.ProductsInOrder!)
            {
                BO.Product product = _dal.product.Read(prod.ProductId)!.CastProduct();
                product.Amount -= prod.ProductAmount;
                _dal.product.Update(CastProduct(product));
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }




}

