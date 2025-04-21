using DO;
using DalApi;
using System.Reflection;

namespace Dal;

internal class CustomerImplementation : Icustomer
{    
    public int Create(Customer item)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Customer newC = DataSource.customers.FirstOrDefault(c => c == item);
            DataSource.customers.Add(item);
            Tools.LogManager.WriteToFile(progName, method, "end");
            return item.id;
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "error");
            throw new DalIdAlreadyExist("this id is been exist");
        }
        
    }
    public void Delete(int id)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToFile(progName, method, "begin");
        Customer customer = Read(id);
        DataSource.customers.Remove(customer);
        Tools.LogManager.WriteToFile(progName, method, "end");
    }
    public Customer? Read(int id)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Customer newC = DataSource.customers.FirstOrDefault(c => c.id == id);
            Tools.LogManager.WriteToFile(progName, method, "end");
            return newC;
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "error");
            throw new DalIdNotExist("this id is not exist");
        } 
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Tools.LogManager.WriteToFile(progName, method, "end");
            return DataSource.customers.First(filter);
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "error");
            throw new DalIdNotExist("this id or another something is not exist");
        }
    }
    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToFile(progName, method, "begin");
        Tools.LogManager.WriteToFile(progName, method, "end");
        if (filter == null) 
            return new List<Customer>(DataSource.customers);
        else
             return DataSource.customers.FindAll(s => filter(s)).ToList();
        
    }
    public void Update(Customer item)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToFile(progName, method, "begin");
        Delete(item.id);
        DataSource.customers.Add(item);
        Tools.LogManager.WriteToFile(progName, method, "end");
    }
}
