using System.Reflection;
using System.Text;
using DO;

namespace BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T obj, string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
            Type t = obj?.GetType() ?? throw new Exception("Obj is NULL");
            foreach (PropertyInfo prop in t.GetProperties())
            {
                if (prop.PropertyType.IsPrimitive
                    || prop.PropertyType == typeof(string)
                    || prop.PropertyType == typeof(DateTime))
                    sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(obj)}");
                else
                    sb.Append($"{prefix}{prop.Name} =\n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
            }
            return sb.ToString();
        }
        
        public static Customer CastCustomer(this DO.Customer customer)
        {
            Customer c = new Customer(customer.id, customer.name, customer.address, customer.phone);
            return c;
        }
        
        public static DO.Customer CastCustomer(Customer customer)
        {
            return new DO.Customer(customer.Id, customer.Name, customer.Address, customer.Phone);
        }
        
        public static Product CastProduct(this DO.Product product)
        {
            return new Product(product.identity, product.name, product.price, product.amount, (BO.Category)product.c);
        }
        
        public static DO.Product CastProduct(Product? product)
        {
            return new DO.Product(product.Identity, product.Name, product.Price, product.Amount, (DO.Category?)product.c);
        }
        
        public static Sale CastSale(this DO.Sale sale)
        {
            return new BO.Sale(sale.code, sale.id, sale.minimumAmount, sale.sum, sale.isNeedClub, sale.beginSale, sale.endSale);
        }
        
        public static DO.Sale CastSale(BO.Sale sale)
        {
            return new DO.Sale(sale.Code, sale.Id, sale.MinimumAmount, sale.Sum, sale.IsNeedClub, sale.BeginSale, sale.EndSale);
        }

        public static SaleInProduct CastSaleToSaleInProduct(this DO.Sale s)
        {
            return new BO.SaleInProduct(s.code, s.minimumAmount, s.sum, s.isNeedClub);
        }

        public static ProductInOrder CastProductToProductInOrder(DO.Product p, int amount)
        {
            return new ProductInOrder(p.identity, p.name, p.price, amount, null, p.price * amount);
        }

        public static DO.Category CastCategory(BO.Category cat)
        {
            Enum.TryParse<DO.Category>(cat.ToString(), out DO.Category category);
            return category;
        }

        public static BO.Category? CastCategory(DO.Category? cat)
        {
            Enum.TryParse<BO.Category>(cat.ToString(), out BO.Category category);
            return category;
        }
    }
}
