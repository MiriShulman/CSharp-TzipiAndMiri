using DO;

namespace Dal
{
    internal static class DataSource
    {
        internal static List<Sale?> sales = new List<Sale?>();
        internal static List<Customer?> customers = new List<Customer?>();
        internal static List<Product?> products = new List<Product?>();
        internal static class Config{
            internal const int productMinCode = 73952;
            internal const int saleMinCode = 375;
            private static int productIndex = productMinCode;
            private static int saleIndex = saleMinCode;
            public static int ProductCode
            {
                get { return productIndex+=7; }
            }
            public static int SaleCode
            {
                get { return saleIndex += 7; }
            }
        }

}
   
}
