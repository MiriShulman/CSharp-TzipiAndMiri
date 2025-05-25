using BlApi;
using System;
using static BO.Tools;

namespace BllImplementation;
internal class ImplementationProduct : IProduct
{
     private DalApi.IDal _dal = DalApi.Factory.Get;

    //Creates new entity object in DAL
    public int Create(BO.Product product)
        {
            try
            {
                return _dal.Product.Create(CastProduct(product)); 
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
                return _dal.Product.Read(id).CastProduct();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

    //stage 1 only, Reads all entity objects and stage 2
    public List<BO.Product> ReadAll(Func<BO.Product, bool> filter)
        {
            try
            {
            Func<DO.Product, bool>? filterDO = filter == null ? null : (p => filter(p.CastProduct()));
            return [.. _dal.Product.ReadAll(filterDO).Select(p => p!.CastProduct())];
            //return _dal.Product.ReadAll(p => filter(p.CastProduct()))
            //        .Select (p => p.CastProduct()).ToList();
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
                _dal.Product.Update(CastProduct(p));
            }
            catch(Exception ex) 
                { throw ex; }
        }
        
    //Deletes an object by its Id
    public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch(Exception e)
                    { throw e; }
        }
        
    //stage 2
    public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try { 
    
                    return _dal.Product.Read(p => filter(p.CastProduct()))?.CastProduct();
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

            return _dal.Sale.ReadAll(s => s.code == ProductId && s.beginSale <= DateTime.Now && s.endSale >= DateTime.Now && (s.isNeedClub == false || s.isNeedClub == PreferredCustomer)).Select(s => s.CastSale().CastFromSaleToSaleInOrder()).ToList();

        }
        catch (Exception e)
        {
            throw e;
        }
    }

}
