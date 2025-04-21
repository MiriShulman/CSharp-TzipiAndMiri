
using DalApi;
using System.ComponentModel;

namespace Dal { 
    internal sealed class DalList : IDal
    {
        public static DalList Instance { get; } = new DalList();
        private DalList() { }
        public Icustomer customer => new CustomerImplementation();
        public Isale sale => new SaleImplementation();
        public Iproduct product => new ProductImplementation();
    }
}