using BlApi;
using System;
using static BO.Tools;

internal class ImplementationProduct : IProduct
{
     private DalApi.IDal _dal = DalApi.Factory.Get;

    //Creates new entity object in DAL
    public int Create(BO.Product product)
        {
            try
            {
                return _dal.product.Create(CastProduct(product)); 
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    //Reads entity object by its ID 
    public BO.Product? Read(int id)
        {
            try
            {
                return _dal.product.Read(id).CastProduct();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

    //stage 1 only, Reads all entity objects and stage 2
    public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                return _dal.product.ReadAll(p => filter(p.CastProduct()))
                    .Select (p => p.CastProduct()).ToList();
            }
            catch(Exception e) {
                 throw e;
            }
        }
        
    //Updates entity object
    public void Update(BO.Product p)
        {
            try
            {
                _dal.product.Update(CastProduct(p));
            }
            catch(Exception ex) 
                { throw ex; }
        }
        
    //Deletes an object by its Id
    public void Delete(int id)
        {
            try
            {
                _dal.product.Delete(id);
            }
            catch(Exception e)
                    { throw e; }
        }
        
    //stage 2
    public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try { 
    
                    return _dal.product.Read(p => filter(p.CastProduct()))?.CastProduct();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        
    //return list of the sales about the products that been in this order
    public List<BO.SaleInProduct> SaleInProductsList(int ProductId, bool PreferredCustomer)
    {
        try
        {

            return CastProduct(_dal.product);
        }
        catch(Exception e)
        {
            throw e;
        }
    }

}
