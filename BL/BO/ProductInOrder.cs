using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    //ישות עזר להזמנות - רשימת המוצרים שנמצאים בהזמנה זו
    //כל אובייקט ברשימה יכיל: מזהה מוצר, שם מוצר, מחיר בסיסי למוצר, כמות ממוצר זה, רשימת המבצעים השייכים למבצע זה, מחיר סופי
    public class ProductInOrder
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double? ProductBasePrice { get; set; }
        public int? ProductAmount { get; set; }
        public List<SaleInProduct> SalesInProducts { get; set; }
        public double? TotalSum { get; set; }

        public ProductInOrder(int id, string name, double? baseP, int? amount, List<SaleInProduct> sales, double? total)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.ProductBasePrice = baseP;
            this.ProductAmount = amount;
            this.SalesInProducts = sales;
            this.TotalSum = total;
        }

    }
}
