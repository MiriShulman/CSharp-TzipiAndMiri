using BO;

namespace BlApi
{
    public interface IOrder
    {
        List<SaleInProduct> AddProductToOrder(Order order, int ProductId, int amount); //return list of sales that add in this product's add
        void CalcTotalPriceForProduct(BO.ProductInOrder? product); //calc the total price of this product
        void CalcTotalPrice(Order order); //calc the total sum of this order
        void DoOrder(Order Order); //invite this order
        void SearchSaleForProduct(BO.ProductInOrder? product, bool IsPreferredCustomer);

    }
}

