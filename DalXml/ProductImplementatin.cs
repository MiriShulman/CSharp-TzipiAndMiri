using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Tools;

namespace Dal;

[XmlRoot("ArrayOfProducts")]
public class Item
{
    [XmlElement("Item")] // שם האלמנט של כל אובייקט
    public string Name { get; set; }
}

public class ProductImplementation : Iproduct
{

    public int Create(Product item)
    {
        //try
        //{
        //    string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
        //    string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
        //    string path = Path.Combine(parentDirectory, "xml", "products.xml");
        //    //string path = Path.Combine(Path.GetDirectoryName("xml"), "products.xml");
        //    Console.WriteLine(path);
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("ArrayOfProducts"));
        //    List<Product> products = GetProductList();
        //    String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        //    String method = MethodBase.GetCurrentMethod().Name;
        //    Tools.LogManager.WriteToLog(progName, method, "begin");
        //    Product newP = products.FirstOrDefault(p => p == item);
        //    Product p = item with { identity = Config.GetProductCode() };
        //    products.Add(p);
        //    using (FileStream fileStream = new FileStream(path, FileMode.Create))
        //    {
        //        serializer.Serialize(fileStream, products);
        //    }
        //    Tools.LogManager.WriteToLog(progName, method, "end");
        //    return p.identity;
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create product");
            List<Product>? products = new List<Product>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("ArrayOfProducts"));

            string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
            string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
            string file_path = Path.Combine(parentDirectory, "xml", "products.xml");
            using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                try
                {
                    products = serializer.Deserialize(fs) as List<Product>;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                if (products != null && products.Contains(item))
                {
                    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product are exists");
                    throw new DalIdAlreadyExist("product are exists");
                }
                Product p = item with { identity = Config.productCode };
                products.Add(p);
                fs.Position = 0;
                serializer.Serialize(fs, products);
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create product");
            return item.identity;
        }
        catch(Exception e)
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "error");
            throw new DalIdAlreadyExist("this id is been exist");
        }
    }

    public void Delete(int id)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");
        Product p = Read(id);
        GetProductList().Remove(p);
        Tools.LogManager.WriteToLog(progName, method, "end");
    }
    public Product? Read(int id)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "begin");
            Product newP = GetProductList().FirstOrDefault(p => p.identity == id);
            Tools.LogManager.WriteToLog(progName, method, "end");
            return newP;
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "error");
            throw new DalIdNotExist("this id is not exist");
        }

    }
    public Product? Read(Func<Product, bool> filter)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "begin");
            Tools.LogManager.WriteToLog(progName, method, "end");
            return GetProductList().First(filter);
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "error");
            throw new DalIdNotExist("this id or another something is not exist");
        }
    }
    public List<Product> ReadAll(Func<Product, bool>? filter = null)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");
        Tools.LogManager.WriteToLog(progName, method, "end");
        if (filter == null)
            return new List<Product>(GetProductList());
        return GetProductList().FindAll(s => filter(s)).ToList();

    }
    public void Update(Product item)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");
        Delete(item.identity);
        GetProductList().Add(item);
        Tools.LogManager.WriteToLog(progName, method, "end");
    }

    public List<Product> LoadProductsFromXml(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("ArrayOfProducts"));
        List<Product> products = new List<Product>();

        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                products = serializer.Deserialize(fileStream) as List<Product>;
            }
            return products;
        }
        catch (Exception ex)
        {
            // הדפס את השגיאה או נהל אותה בהתאם
            Console.WriteLine("vhfhjjl;k,'lvyrdgj!!!!!!!!!!!!!!!! \n");
            Console.WriteLine($"Error: {ex.Message}");
            throw; // או נהל את השגיאה בהתאם לצורך
        }
        //using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        //{
        //    return (List<Product>)serializer.Deserialize(fileStream);
        //}
    }

    public List<Product> GetProductList()
    {
        string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
        string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
        string path = Path.Combine(parentDirectory, "xml", "products.xml");
        //string path = Path.Combine(Path.GetDirectoryName("xml"), "products.xml");
        return LoadProductsFromXml(path);
    }
    
}
