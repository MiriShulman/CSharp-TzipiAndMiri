using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalXml : IDal
    {
        public static DalXml XmlInstance { get; } = new DalXml();

        public DalXml() { }

        public Icustomer customer => new CustomerImplementation();

        public Isale sale => new SaleImplementation();

        public Iproduct product => new ProductImplementation();
    }
}
