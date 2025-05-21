
using DalApi;
using System.ComponentModel;

namespace Dal { 
    internal sealed class DalList : IDal
    {
        public static readonly DalList instance = new DalList();
        public static DalList Instance { get { return instance; } }
        public Icustomer Customer => new CustomerImplementation();
        public Isale Sale => new SaleImplementation();
        public Iproduct Product => new ProductImplementation();
        private DalList() { }
    }
}