using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dal
{
    public class Config
    {
        private static string ConfigFileName = "data-config.xml";
        private static int code = 0;
        private static int sale_code = 0;

        public static int productCode
        {
            get
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config), new XmlRootAttribute("config"));
                
                string parentDirectory = System.IO.Path.GetFullPath(ConfigFileName);
                string last = Path.GetFileName(parentDirectory);
                do
                {
                    parentDirectory = Directory.GetParent(parentDirectory).FullName;
                    last = Path.GetFileName(parentDirectory);
                } while (last != "CSharp-TzipiAndMiri");
                
                string file_path = Path.Combine(parentDirectory, "xml", ConfigFileName);

                XElement xml = XElement.Load(file_path);
                code = int.Parse(xml.Element("productMinCode").Value);
                xml.Element("productMinCode").SetValue(++code);

                // שמירת השינויים לקובץ
                xml.Save(file_path);

                return code;
            }
        }

        public static int saleCode
        {
            get {
                XmlSerializer serializer = new XmlSerializer(typeof(Config), new XmlRootAttribute("config"));
                string parentDirectory = System.IO.Path.GetFullPath(ConfigFileName);
                string last = Path.GetFileName(parentDirectory);
                do
                {
                    parentDirectory = Directory.GetParent(parentDirectory).FullName;
                    last = Path.GetFileName(parentDirectory);
                } while (last != "CSharp-TzipiAndMiri");

                string file_path = Path.Combine(parentDirectory, "xml", ConfigFileName);

                XElement xml = XElement.Load(file_path);
                sale_code = int.Parse(xml.Element("saleMinCode").Value);
                xml.Element("saleMinCode").SetValue(++sale_code);
                xml.Save(file_path);
                return sale_code;
            }
        }
        //public int productMinCode { get; set; } // הוסף מאפיין זה
        //public int saleMinCode { get; set; } // הוסף מאפיין זה
    }
}
