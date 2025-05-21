using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using System.Data.Common;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using Tools;

namespace Dal;

internal class SaleImplementation : Isale
{
    private const string CODE = "code";
    private const string ID = "id";
    private const string MINIMUMAMOUNT = "minimumAmount";
    private const string SUM = "sum";
    private const string ISNEEDCLUB = "isNeedClub";
    private const string BEGINSALE = "beginSale";
    private const string ENDSALE = "endSale";


    public int Create(Sale item)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create sale");
            List<Sale>? sales = new List<Sale>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>), new XmlRootAttribute("ArrayOfSales"));

            string currentDirectory = Directory.GetCurrentDirectory(); // מקבל את התיקייה הנוכחית
            string parentDirectory = Directory.GetParent(currentDirectory).FullName; // מקבל את התיקייה ההורה
            string file_path = Path.Combine(parentDirectory, "xml", "sales.xml");
            using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                try
                {
                    sales = serializer.Deserialize(fs) as List<Sale>;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                if (sales != null && sales.Contains(item))
                {
                    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "sale are exists");
                    throw new DalIdAlreadyExist("sale are exists");
                }
                Sale s = item with { id = Config.saleCode };
                sales.Add(s);
                fs.Position = 0;
                serializer.Serialize(fs, sales);
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create sale");
            return item.id;
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
        XElement xml;
        string path = Path.Combine(Path.GetDirectoryName("xml"), "sales.xml");
        xml = XElement.Load(path);
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");
        xml.Elements().FirstOrDefault(e => (int)e.Element(ID) == id)?.Remove();
        Tools.LogManager.WriteToLog(progName, method, "end");
    }
    public Sale? Read(int id)
    {
        try
        {
            XElement xml;
            string path = Path.Combine(Path.GetDirectoryName("xml"), "sales.xml");
            xml = XElement.Load(path);
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "begin");
            Sale s = GetSalesList().FirstOrDefault(e => e.id == id);
            Tools.LogManager.WriteToLog(progName, method, "end");
            return s;
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "error");
            throw new DalIdNotExist("this id is not exist");
        }
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            XElement? xml;
            string path = Path.Combine(Path.GetDirectoryName("xml"), "sales.xml");
            xml = XElement.Load(path);
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "begin");
            Tools.LogManager.WriteToLog(progName, method, "end");
            return GetSalesList().First(filter);
        }
        catch
        {
            String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
            String method = MethodBase.GetCurrentMethod().Name;
            Tools.LogManager.WriteToLog(progName, method, "error");
            throw new DalIdNotExist("this id or another something is not exist");
        }
    }
    public List<Sale> ReadAll()
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");
        Tools.LogManager.WriteToLog(progName, method, "end");
        List<Sale> sales = GetSalesList();
        return sales;
    }
    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "error");
        List<Sale> sales = GetSalesList();
        if (filter == null)
            return sales;
        return sales.FindAll(s => filter(s)).ToList();
    }
    public void Update(Sale item)
    {
        XElement xml;
        string path = Path.Combine(Path.GetDirectoryName("xml"), "sales.xml");
        xml = XElement.Load(path);
        String progName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        String method = MethodBase.GetCurrentMethod().Name;
        Tools.LogManager.WriteToLog(progName, method, "begin");
        Delete(item.id);
        xml.Add(CastSaleToXElement(item));
        Tools.LogManager.WriteToLog(progName, method, "end");
    }
    public List<Sale> GetSalesList()
    {
        XElement xml;
        string path = Path.Combine(Path.GetDirectoryName("xml"), "sales.xml");
        xml = XElement.Load(path);
        return (xml.Elements("Sale")
            .Select(x => new Sale
            {
                code = (int)x.Element(CODE),
                id = (int)x.Element(ID),
                minimumAmount = (int)x.Element(MINIMUMAMOUNT),
                sum = (double)x.Element(SUM),
                isNeedClub = (Boolean)x.Element(ISNEEDCLUB),
                beginSale = (DateTime)x.Element(BEGINSALE),
                endSale = (DateTime)x.Element(ENDSALE)
            }).ToList());
    }
    public XElement CastSaleToXElement(Sale s)
    {
        return new XElement("Sale", new XElement(CODE, s.code),
                new XElement(ID, s.id),
                new XElement(MINIMUMAMOUNT, s.minimumAmount),
                new XElement(SUM, s.sum),
                new XElement(ISNEEDCLUB, s.isNeedClub),
                new XElement(BEGINSALE, s.beginSale),
                new XElement(ENDSALE, s.endSale));
    }
}