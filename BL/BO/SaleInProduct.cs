using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    //ישות עזר להזמנות - רשימת המבצעים שההזמנה מכילה (כדי להוריד הנחות)
    //כל אובייקט ברשימה יכיל: מספר הזמנה, כמות מוצרים, מחיר סופי, והאם המבצע הוא לכל הלקוחות
    public class SaleInProduct
    {
        public int Id {  get; }
        public int? Amount { get; }
        public double? Price { get; }
        public bool? IsNeedClub { get; }

        public SaleInProduct(int id, int? amount, double? price, bool? club)
        {
            this.Id = id;
            this.Amount = amount;
            this.Price = price;
            this.IsNeedClub = club | false;
        }
    }
}
