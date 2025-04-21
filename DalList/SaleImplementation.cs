using DO;
using DalApi;
using System.Reflection;

namespace Dal;

internal class SaleImplementation : Isale
{
    public int Create(Sale item)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Sale newS = DataSource.sales.FirstOrDefault(s => s == item);
            Sale s = item with { id = DataSource.Config.SaleCode };
            DataSource.sales.Add(s);
            Tools.LogManager.WriteToFile(progName, method, "end");
            return s.id;
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
        Sale s = Read(id);
        DataSource.sales.Remove(s);
        Tools.LogManager.WriteToFile(progName, method, "end");
    }
    public Sale? Read(int id)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Sale newS = DataSource.sales.FirstOrDefault(s => s.id == id);
            Tools.LogManager.WriteToFile(progName, method, "end");
            return newS;
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "error");
            throw new DalIdNotExist("this id is not exist");
        }
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "begin");
            Tools.LogManager.WriteToFile(progName, method, "end");
            return DataSource.sales.First(filter);
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToFile(progName, method, "error");
            throw new DalIdNotExist("this id or another something is not exist");
        }   
    }
    public List<Sale> ReadAll()
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToFile(progName, method, "begin");
        Tools.LogManager.WriteToFile(progName, method, "end");
        return new List<Sale>(DataSource.sales);
    }
    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToFile(progName, method, "error");
        if (filter == null)
            return new List<Sale>(DataSource.sales);
        return DataSource.sales.FindAll(s => filter(s)).ToList();
    }
    public void Update(Sale item)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToFile(progName, method, "begin");
        Delete(item.id);
        DataSource.sales.Add(item);
        Tools.LogManager.WriteToFile(progName, method, "end");
    }
}