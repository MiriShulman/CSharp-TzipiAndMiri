using DO;
using DalApi;
using System.Reflection;

namespace Dal;

internal class ProductImplementation : Iproduct
{
    public int Create(Product item)
    {
        try
        {
            Console.WriteLine("create prod");

            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "begin");
            Product newP = DataSource.products.FirstOrDefault(p => p == item);
            Console.WriteLine("create prod");

            Product p = item with { identity = DataSource.Config.ProductCode };
            DataSource.products.Add(p);
            Tools.LogManager.WriteToLog(progName, method, "end");
            return p.identity;
        }
        catch
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
        DataSource.products.Remove(p);
        Tools.LogManager.WriteToLog(progName, method, "end");
    }
    public Product? Read(int id)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "begin");
            Product newP = DataSource.products.FirstOrDefault(p => p.identity == id);
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
            return DataSource.products.First(filter);
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "error");
            throw new DalIdNotExist("this id or another something is not exist");
        }
    }
    public List<Product> ReadAll(Func<Product, bool>? filter = null) {
        Console.WriteLine("readAll prod");

        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");
        Tools.LogManager.WriteToLog(progName, method, "end");
        if (filter == null)
            return new List<Product>(DataSource.products);
        return DataSource.products.FindAll(s => filter(s)).ToList();

    }
    public void Update(Product item)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");
        Delete(item.identity);
        DataSource.products.Add(item);
        Tools.LogManager.WriteToLog(progName, method, "end");
    }
}