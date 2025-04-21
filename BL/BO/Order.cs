using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool PreferredCustomer { get; }
        public List<ProductInOrder> ProductsInOrder { get; set; }
        public double? Price { get; set; }

        public Order(bool preferred, List<ProductInOrder> productIn, double price)
        {
            this.PreferredCustomer = preferred;
            this.ProductsInOrder = productIn;
            this.Price = price;

        }
        public override string ToString() => this.ToStringProperty();
    }
}
