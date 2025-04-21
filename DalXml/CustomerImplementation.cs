using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal;

internal class CustomerImplementation: Icustomer
{

    public int Create(Customer item)
    {
        try
        {
            string path = Path.Combine(Path.GetDirectoryName("xml"), "customers.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            List<Customer> customers = GetCustomersList();
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Customer newC = customers.FirstOrDefault(c => c == item);
            //Customer c = item with { identity = Config.ProductCode };
            customers.Add(newC);
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fileStream, customers);
            }
            Tools.LogManager.WriteToFile(progName, method, "end");
            return newC.id;
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
        Customer c = Read(id);
        GetCustomersList().Remove(c);
        Tools.LogManager.WriteToFile(progName, method, "end");
    }
    public Customer? Read(int id)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Customer newC = GetCustomersList().FirstOrDefault(c => c.id == id);
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
            return GetCustomersList().First(filter);
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
            return new List<Customer>(GetCustomersList());
        return GetCustomersList().FindAll(s => filter(s)).ToList();

    }
    public void Update(Customer item)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToFile(progName, method, "begin");
        Delete(item.id);
        GetCustomersList().Add(item);
        Tools.LogManager.WriteToFile(progName, method, "end");
    }

    public List<Customer> LoadCustomersFromXml(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("customer"));
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            return (List<Customer>)serializer.Deserialize(fileStream);
        }
    }

    public List<Customer> GetCustomersList()
    {
        string path = Path.Combine(Path.GetDirectoryName("xml"), "customers.xml");
        return LoadCustomersFromXml(path);
    }


}
