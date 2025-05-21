using Dal;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalXml
{
    public class DalXml : IDal
    {
        public static readonly DalXml instance = new DalXml();
        public static DalXml Instance { get { return instance; } }
        //public DalXml() { }

        public Icustomer Customer => new CustomerImplementation();

        public Isale Sale => new SaleImplementation();

        public Iproduct Product => new ProductImplementation();
    }
}
