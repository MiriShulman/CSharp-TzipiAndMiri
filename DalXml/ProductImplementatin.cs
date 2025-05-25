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

        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create product");
            List<Product>? products = new List<Product>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("ArrayOfProducts"));

            //string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
            //string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
            //string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
            //string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
            string parentDirectory = System.IO.Path.GetFullPath("ProductImplementation.cs");
            string last = Path.GetFileName(parentDirectory);
            do
            {
                parentDirectory = Directory.GetParent(parentDirectory).FullName; // מקבל את התיקייה ההורה
                last = Path.GetFileName(parentDirectory);
            } while (last != "CSharp-TzipiAndMiri");

            //string path = Path.Combine(parentDirectory, "xml", "products.xml");
            string file_path = Path.Combine(parentDirectory, "xml", "products.xml");
            //string file_path = Path.Combine(parentDirectory, "xml", "products.xml");
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

        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("ArrayOfProducts"));

        //string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
        //string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
        //string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
        //string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
        string parentDirectory = System.IO.Path.GetFullPath("ProductImplementation.cs");
        string last = Path.GetFileName(parentDirectory);
        do
        {
            parentDirectory = Directory.GetParent(parentDirectory).FullName; // מקבל את התיקייה ההורה
            last = Path.GetFileName(parentDirectory);
        } while (last != "CSharp-TzipiAndMiri");

        //string path = Path.Combine(parentDirectory, "xml", "products.xml");
        //string file_path = Path.Combine(parentDirectory, "xml", "products.xml");
        string file_path = Path.Combine(parentDirectory, "xml", "products.xml");

        Product p = Read(id);

        List<Product> products = new List<Product>();

        using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
        {
            try
            {
                products = serializer.Deserialize(fs) as List<Product>;
                products.Remove(p);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
            
        using (FileStream fsWrite = new FileStream(file_path, FileMode.Create, FileAccess.Write))
        {
            serializer.Serialize(fsWrite, products); // כותב את הרשימה המעודכנת
        }
        Tools.LogManager.WriteToLog(progName, method, "end");

    }
    public Product? Read(int id)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "begin");
            List<Product> products = GetProductList();
            Product newP = products.FirstOrDefault(p => p.identity == id);
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
            return GetProductList();
        return GetProductList().FindAll(p => filter(p)).ToList();

    }
    public void Update(Product item)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("ArrayOfProducts"));

        string parentDirectory = System.IO.Path.GetFullPath("CustomerImplementation.cs");
        string last = Path.GetFileName(parentDirectory);
        do
        {
            parentDirectory = Directory.GetParent(parentDirectory).FullName; // מקבל את התיקייה ההורה
            last = Path.GetFileName(parentDirectory);
        } while (last != "CSharp-TzipiAndMiri");

        string file_path = Path.Combine(parentDirectory, "xml", "products.xml");

        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;

        List<Product> products = new List<Product>();

        Tools.LogManager.WriteToLog(progName, method, "begin");
        Product p = Read(item.identity);
        Category category = (Category)p.c;

        Delete(item.identity);
        Product newP = item with { c = category };
        products = GetProductList();
        
        products.Add(newP);

        using (FileStream fsWrite = new FileStream(file_path, FileMode.Create, FileAccess.Write))
        {
            serializer.Serialize(fsWrite, products); // כותב את הרשימה המעודכנת
        }
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
            Console.WriteLine($"Error: {ex.Message}");
            throw; // או נהל את השגיאה בהתאם לצורך
        }
    }

    public List<Product> GetProductList()
    {
        //LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create product");
        //List<Product>? sales = new List<Product>();
        //XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("ArrayOfProducts"));
        //string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
        //string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
        //string path = @"Z:\B\קלרברג ציפורה\c#\CSharp-TzipiAndMiri\xml\products.xml";
        string parentDirectory = System.IO.Path.GetFullPath("ProductImplementation.cs");
        string last = Path.GetFileName(parentDirectory);
        do
        {
            parentDirectory = Directory.GetParent(parentDirectory).FullName; // מקבל את התיקייה ההורה
            last = Path.GetFileName(parentDirectory);
        } while (last != "CSharp-TzipiAndMiri");

        string path = Path.Combine(parentDirectory, "xml", "products.xml");
        //string path = Path.Combine(parentDirectory, "xml", "customers.xml");
        return LoadProductsFromXml(path);
    }
    
}
