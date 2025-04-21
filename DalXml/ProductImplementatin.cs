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
            string path = Path.Combine(Path.GetDirectoryName("xml"), "products.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            List<Product> products = GetProductList();
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Product newP = products.FirstOrDefault(p => p == item);
            Product p = item with { identity = Config.GetProductCode() };
            products.Add(p);
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fileStream, products);
            }
            Tools.LogManager.WriteToFile(progName, method, "end");
            return p.identity;
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
        Product p = Read(id);
        GetProductList().Remove(p);
        Tools.LogManager.WriteToFile(progName, method, "end");
    }
    public Product? Read(int id)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Product newP = GetProductList().FirstOrDefault(p => p.identity == id);
            Tools.LogManager.WriteToFile(progName, method, "end");
            return newP;
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "error");
            throw new DalIdNotExist("this id is not exist");
        }

    }
    public Product? Read(Func<Product, bool> filter)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Tools.LogManager.WriteToFile(progName, method, "end");
            return GetProductList().First(filter);
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "error");
            throw new DalIdNotExist("this id or another something is not exist");
        }
    }
    public List<Product> ReadAll(Func<Product, bool>? filter = null)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToFile(progName, method, "begin");
        Tools.LogManager.WriteToFile(progName, method, "end");
        if (filter == null)
            return new List<Product>(GetProductList());
        return GetProductList().FindAll(s => filter(s)).ToList();

    }
    public void Update(Product item)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToFile(progName, method, "begin");
        Delete(item.identity);
        GetProductList().Add(item);
        Tools.LogManager.WriteToFile(progName, method, "end");
    }

    public List<Product> LoadProductsFromXml(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("product"));
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            return (List<Product>)serializer.Deserialize(fileStream);
        }
    }

    public List<Product> GetProductList()
    {
        string path = Path.Combine(Path.GetDirectoryName("xml"), "products.xml");
        return LoadProductsFromXml(path);
    }
    
}
