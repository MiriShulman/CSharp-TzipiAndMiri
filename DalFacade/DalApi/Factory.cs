using static DalApi.DalConfig;
using System.Reflection;

namespace DalApi;

public static class Factory
{
    public static IDal Get
    {
        get
        {
            //מכיל את 'xml'
            string dalType = s_dalName ?? throw new DalConfigException($"DAL name is not extracted from the configuration");

            //מכיל את 'DalXml'
            string dal = s_dalPackages[dalType] ?? throw new DalConfigException($"Package for {dalType} is not found in packages list in dal-config.xml");

            try { Assembly.Load(dal ?? throw new DalConfigException($"Package {dal} is null")); }
            catch (Exception ex) { throw new DalConfigException($"Failed to load {dal}.dll package", ex); }

            //מכיל את 'DalXml.DalXml'
            Type type = Type.GetType($"DalXml.{dal}, {dal}") ??
                throw new DalConfigException($"Class Dal.{dal} was not found in {dal}.dll");
            //Console.WriteLine(type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static).GetValue(null) as IDal);
            return type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as IDal ??
                throw new DalConfigException($"Class {dal} is not a singleton or wrong property name for Instance");
        }
    }
}
