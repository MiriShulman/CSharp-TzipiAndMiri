namespace DalApi;
using System.Xml.Linq;
static class DalConfig
{
    internal static string s_dalName;
    internal static Dictionary<string, string> s_dalPackages;


    static DalConfig()
    {
        Console.WriteLine("why?");
        string parentDirectory = System.IO.Path.GetFullPath("dal-config.xml");
        string last = Path.GetFileName(parentDirectory);
        do
        {
            parentDirectory = Directory.GetParent(parentDirectory).FullName;
            last = Path.GetFileName(parentDirectory);
        } while (last != "CSharp-TzipiAndMiri");

        string file_path = Path.Combine(parentDirectory, "xml", "dal-config.xml");
        XElement dalConfig = XElement.Load(file_path) ??
            throw new DalConfigException("dal-config.xml file is not found");
        Console.WriteLine("why?");
        s_dalName = dalConfig.Element("dal")?.Value ?? throw new DalConfigException("<dal> element is missing");
        var packages = dalConfig.Element("dal-packages")?.Elements() ??
            throw new DalConfigException("<dal-packages> element is missing");
        s_dalPackages = packages.ToDictionary(p => "" +p.Name, p => p.Value);
    }
}
[Serializable]
public class DalConfigException : Exception
{
    public DalConfigException(string msg) : base(msg) { }
    public DalConfigException(string msg, Exception ex) : base(msg, ex) { }
}