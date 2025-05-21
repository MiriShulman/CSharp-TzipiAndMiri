using BlApi;
using System;
using static BO.Tools;

internal class ImplementationSale : ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    //Creates new entity object in DAL
    public int Create(BO.Sale sale)
        {
            try
            {
                return _dal.Sale.Create(CastSale(sale));
            }
            catch(Exception e)
            { throw e; }
        }

    //Reads entity object by its ID 
    BO.Sale? ISale.Read(int id)
        {
            try
            {
                return _dal.Sale.Read(id).CastSale();
            }
            catch(Exception e) {  throw e; }
        }

    //stage 1 only, Reads all entity objects and stage 2
    public List<BO.Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                return _dal.Sale.ReadAll(p => filter(p.CastSale()))
                .Select(p => p.CastSale()).ToList();
            }
            catch(Exception e) { throw e ; }

        }
    
    //Updates entity object
    public void Update(BO.Sale sale)
        {
            try
            {
                _dal.Sale.Update(CastSale(sale));
            }
            catch(Exception ex) { throw ex; }
        }
    
    //Deletes an object by its Id
    void ISale.Delete(int id)
        {
            try
            {
                _dal.Sale.Delete(id);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        
    //stage 2
    public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                return _dal.Sale.Read(s => filter(s.CastSale()))?.CastSale();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

}

