using BlApi;
using System;
using static BO.Tools;

internal class ImplementationCustomer : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    //Creates new entity object in DAL
    public int Create(BO.Customer customer)
    {
        try
        {
            return _dal.customer.Create(CastCustomer(customer));
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    //Reads entity object by its ID 
    BO.Customer? ICustomer.Read(int id)
    {
        try
        {
            return _dal.customer.Read(id).CastCustomer();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    //stage 1 only, Reads all entity objects and stage 2
    public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            return _dal.customer.ReadAll(c => filter(c.CastCustomer()))
                .Select(c => c.CastCustomer()).ToList();
        } catch (Exception ex)
        {
            throw ex;
        }
    }
    
    //Updates entity object
    public void Update(BO.Customer c)
    {
        try
        {
            _dal.customer.Update(CastCustomer(c));
        } catch (Exception e)
        {
            throw e;
        }
    }
    
    //Deletes an object by its Id
    public void Delete(int id)
    {
        try
        {
            _dal.customer.Delete(id);
        } catch (Exception e)
        {
            throw e;
        }
    }
    
    //stage 2
    public BO.Customer? Read(Func<BO.Customer, bool> filter)
    {
        try
        {
            return _dal.customer.Read(c => filter(c.CastCustomer()))?.CastCustomer();
        }
        catch (Exception e) {
            throw e;
        }
   
    }
    
    public bool IsCustomerExist(int id)
    {
        throw new NotImplementedException();
    }

}
