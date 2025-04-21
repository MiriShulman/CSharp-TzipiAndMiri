using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
       public int Identity { get; }
       public string? Name { get; }
       public double? Price { get; }
       public int? Amount { get; set; }
       public Category? c { get; }
       List<SaleInProduct> SalesInProduct { get; }

        public Product(int identity, string? name, double? price, int? amount, Category? category)
        {
            this.Identity = identity;
            this.Name = name;
            this.Price = price;
            this.Amount = amount;
            this.c = category;
            this.SalesInProduct = new List<SaleInProduct>();
        }
        public override string ToString() => this.ToStringProperty();
    }
    
}
