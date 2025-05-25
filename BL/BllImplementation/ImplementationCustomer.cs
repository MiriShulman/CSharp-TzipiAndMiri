using BlApi;
using System;
using static BO.Tools;

using BllImplementation;

internal class ImplementationCustomer : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    //Creates new entity object in DAL
    public int Create(BO.Customer customer)
    {
        try
        {
            return _dal.Customer.Create(CastCustomer(customer));
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
            return _dal.Customer.Read(id).CastCustomer();
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
            return _dal.Customer.ReadAll(c => filter(c.CastCustomer()))
                .Select(c => c.CastCustomer()).ToList();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    //Updates entity object
    public void Update(BO.Customer c)
    {
        try
        {
            _dal.Customer.Update(CastCustomer(c));
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    //Deletes an object by its Id
    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    //stage 2
    public BO.Customer? Read(Func<BO.Customer, bool> filter)
    {
        try
        {
            return _dal.Customer.Read(c => filter(c.CastCustomer()))?.CastCustomer();
        }
        catch (Exception e)
        {
            throw e;
        }

    }

    public bool IsCustomerExist(int id)
    {
        try
        {
            DO.Customer? c = _dal.Customer.Read(cust => cust.id == id);
            return !(c == null);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        //try
        //{
        //    if (_dal.Customer.ReadAll().FirstOrDefault(c => c.id == id) == null)
        //        return false;
        //    return true;
        //}
        //catch (Exception e)
        //{
        //    throw e;
        //}


    }
}
