using BO;

namespace BlApi
{
    public interface IProduct
    {
        int Create(Product Product); //Creates new entity object in DAL
        Product? Read(int id); //Reads entity object by its ID 
        List<Product> ReadAll(Func<Product, bool>? filter = null); //stage 1 only, Reads all entity objects and stage 2
        void Update(Product item); //Updates entity object
        void Delete(int id); //Deletes an object by its Id
        Product? Read(Func<Product, bool> filter); //stage 2
        List<SaleInProduct> SaleInProductsList(int ProductId, bool PreferredCustomer); //return list of the sales about the products that been in this order
    }

}
