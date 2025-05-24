using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tools;

namespace Dal;

internal class CustomerImplementation: Icustomer
{


    //public int Create(Customer item)
    //{
    //    try
    //    {
    //        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create customer");
    //        List<Customer>? customers = new List<Customer>();
    //        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("ArrayOfCustomers"));
    //        //using (var reader = new StringReader(xmlString)));

    //        string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
    //        string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
    //        string file_path = Path.Combine(parentDirectory, "xml", "customers.xml");
    //        using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
    //        {
    //            try
    //            {
    //                customers = serializer.Deserialize(fs) as List<Customer>;

    //            } catch(Exception e)
    //            {
    //                Console.WriteLine(e);
    //            }
    //            if (customers != null && customers.Contains(item))
    //            {
    //                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer are exists");
    //                throw new DalIdAlreadyExist("customer are exists");
    //            }
    //            customers.Add(item);
    //            fs.Position = 0;
    //            serializer.Serialize(fs, customers);
    //        }
    //        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create customer");
    //        return item.id;

    //        //string path = Path.Combine(Path.GetDirectoryName("xml"), "customers.xml");
    //        //XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
    //        //List<Customer> customers = GetCustomersList();
    //        //Console.WriteLine(customers.First());

    //        //String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    //        //String method = MethodBase.GetCurrentMethod().Name;
    //        //Tools.LogManager.WriteToLog(progName, method, "begin");
    //        //Customer newC = customers.FirstOrDefault(c => c == item);
    //        ////Customer c = item with { identity = Config.ProductCode };
    //        //customers.Add(newC);
    //        //using (FileStream fileStream = new FileStream(path, FileMode.Create))
    //        //{
    //        //    serializer.Serialize(fileStream, customers);
    //        //}
    //        //Tools.LogManager.WriteToLog(progName, method, "end");
    //        //return newC.id;
    //    }
    //    catch
    //    {
    //        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    //        String method = MethodBase.GetCurrentMethod().Name;
    //        Tools.LogManager.WriteToLog(progName, method, "error");
    //        throw new DalIdAlreadyExist("this id is been exist");
    //    }
    //}

    //public void Delete(int id)
    //{
    //    String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    //    String method = MethodBase.GetCurrentMethod().Name;
    //    Tools.LogManager.WriteToLog(progName, method, "begin");
    //    Customer c = Read(id);
    //    GetCustomersList().Remove(c);
    //    Tools.LogManager.WriteToLog(progName, method, "end");
    //}
    //public Customer? Read(int id)
    //{
    //    try
    //    {
    //        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    //        String method = MethodBase.GetCurrentMethod().Name;
    //        Tools.LogManager.WriteToLog(progName, method, "begin");
    //        Customer newC = GetCustomersList().FirstOrDefault(c => c.id == id);
    //        Tools.LogManager.WriteToLog(progName, method, "end");
    //        return newC;
    //    }
    //    catch
    //    {
    //        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    //        String method = MethodBase.GetCurrentMethod().Name;
    //        Tools.LogManager.WriteToLog(progName, method, "error");
    //        throw new DalIdNotExist("this id is not exist");
    //    }

    //}
    //public Customer? Read(Func<Customer, bool> filter)
    //{
    //    try
    //    {
    //        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    //        String method = MethodBase.GetCurrentMethod().Name;
    //        Tools.LogManager.WriteToLog(progName, method, "begin");
    //        Tools.LogManager.WriteToLog(progName, method, "end");
    //        return GetCustomersList().First(filter);
    //    }
    //    catch
    //    {
    //        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    //        String method = MethodBase.GetCurrentMethod().Name;
    //        Tools.LogManager.WriteToLog(progName, method, "error");
    //        throw new DalIdNotExist("this id or another something is not exist");
    //    }
    //}
    //public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    //{
    //    String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    //    String method = MethodBase.GetCurrentMethod().Name;
    //    Tools.LogManager.WriteToLog(progName, method, "begin");
    //    Tools.LogManager.WriteToLog(progName, method, "end");
    //    if (filter == null)
    //        return new List<Customer>(GetCustomersList());
    //    return GetCustomersList().FindAll(s => filter(s)).ToList();

    //}
    //public void Update(Customer item)
    //{
    //    String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    //    String method = MethodBase.GetCurrentMethod().Name;
    //    Tools.LogManager.WriteToLog(progName, method, "begin");
    //    Delete(item.id);
    //    GetCustomersList().Add(item);
    //    Tools.LogManager.WriteToLog(progName, method, "end");
    //}

    //public List<Customer> LoadCustomersFromXml(string filePath)
    //{
    //    try
    //    {
    //        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
    //        //, new XmlRootAttribute("customer")
    //        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
    //        {
    //            return (List<Customer>)serializer.Deserialize(fileStream);
    //        }
    //    }
    //    catch(Exception e)
    //    {
    //        throw e;
    //    }
    //}

    //public List<Customer> GetCustomersList()
    //{
    //    string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
    //    string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
    //    string path = Path.Combine(parentDirectory, "xml", "customers.xml");
    //    Console.WriteLine(path);
    //    return LoadCustomersFromXml(path);
    //}
    public int Create(Customer item)
    {

        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create customer");
            List<Customer>? customers = new List<Customer>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("ArrayOfCustomers"));

            string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
            string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
            string file_path = Path.Combine(parentDirectory, "xml", "customers.xml");
            using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                try
                {
                    customers = serializer.Deserialize(fs) as List<Customer>;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                if (customers != null && customers.Contains(item))
                {
                    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer are exists");
                    throw new DalIdAlreadyExist("product are exists");
                }
                Customer p = item with { id = Config.productCode };
                customers.Add(p);
                fs.Position = 0;
                serializer.Serialize(fs, customers);
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create customer");
            return item.id;
        }
        catch (Exception e)
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "error");
            throw new DalIdAlreadyExist("this id is been exist (customer)");
        }
    }

    public void Delete(int id)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");

        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("ArrayOfCustomers"));

        string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
        string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
        string file_path = Path.Combine(parentDirectory, "xml", "customers.xml");

        Customer c = Read(id);

        List<Customer> customers = new List<Customer>();

        using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
        {
            try
            {
                customers = serializer.Deserialize(fs) as List<Customer>;
                customers.Remove(c);
                //fs.Position = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        using (FileStream fsWrite = new FileStream(file_path, FileMode.Create, FileAccess.Write))
        {
            serializer.Serialize(fsWrite, customers); // כותב את הרשימה המעודכנת
        }
        Tools.LogManager.WriteToLog(progName, method, "end");

    }
    public Customer? Read(int id)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "begin");
            List<Customer> customers = GetCustomerList();
            Customer newC = customers.FirstOrDefault(c => c.id == id);
            Tools.LogManager.WriteToLog(progName, method, "end");
            return newC;
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "error");
            throw new DalIdNotExist("this id is not exist (customers)");
        }

    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "begin");
            Tools.LogManager.WriteToLog(progName, method, "end");
            return GetCustomerList().First(filter);
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "error");
            throw new DalIdNotExist("this id or another something is not exist");
        }
    }
    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");
        Tools.LogManager.WriteToLog(progName, method, "end");
        if (filter == null)
            return GetCustomerList();
        return GetCustomerList().FindAll(c => filter(c)).ToList();

    }
    public void Update(Customer item)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("ArrayOfCustomers"));

        string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
        string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
        string file_path = Path.Combine(parentDirectory, "xml", "customers.xml");

        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;

        List<Customer> customers = new List<Customer>();

        Tools.LogManager.WriteToLog(progName, method, "begin");
        Customer c = Read(item.id);

        Delete(item.id);
        //Product newP = item with { c = category };
        customers = GetCustomerList();

        customers.Add(item);

        using (FileStream fsWrite = new FileStream(file_path, FileMode.Create, FileAccess.Write))
        {
            serializer.Serialize(fsWrite, customers); // כותב את הרשימה המעודכנת
        }
        Tools.LogManager.WriteToLog(progName, method, "end");
    }

    public List<Customer> LoadCustomersFromXml(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("ArrayOfCustomers"));
        List<Customer> customers = new List<Customer>();

        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                customers = serializer.Deserialize(fileStream) as List<Customer>;
            }
            return customers;
        }
        catch (Exception ex)
        {
            // הדפס את השגיאה או נהל אותה בהתאם
            Console.WriteLine($"Error: {ex.Message}");
            throw; // או נהל את השגיאה בהתאם לצורך
        }
    }

    public List<Customer> GetCustomerList()
    {
        string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
        string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
        string path = Path.Combine(parentDirectory, "xml", "customers.xml");
        return LoadCustomersFromXml(path);
    }
}
