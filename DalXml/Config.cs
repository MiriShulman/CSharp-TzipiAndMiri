using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class Config
    {
        private static string ConfigFileName = "data-config.xml";

        public static int GetProductCode()
        {
            XElement xml;
            string path = Path.Combine(Path.GetDirectoryName("xml"), ConfigFileName);
            xml = XElement.Load(path);
            int code = int.Parse(xml.Element("productMinCode")?.Value);
            code++;
            xml.Element("productMinCode").SetValue(code);
            return code;
        }

        public static int GetSaleCode()
        {
            XElement xml;
            string path = Path.Combine(Path.GetDirectoryName("xml"), ConfigFileName);
            xml = XElement.Load(path);
            int code = int.Parse(xml.Element("saleMinCode")?.Value);
            code++;
            xml.Element("saleMinCode").SetValue(code);
            return code;
        }
    }
}
