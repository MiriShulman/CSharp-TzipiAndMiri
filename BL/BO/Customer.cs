using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{ 
    //תכונות לקוח
    public class Customer
    {
        public int Id {  get; }
        public string? Name { get; }
        public string? Address {  get; }
        public string? Phone {  get; }

        public Customer(int id, string Name, string Address, string Phone)
        {
            this.Id = id;
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
        }

        public override string ToString() => this.ToStringProperty();
    }
}
