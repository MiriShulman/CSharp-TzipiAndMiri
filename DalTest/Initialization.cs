using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IDal? s_dal;

    private static void createProduct()
    {
        s_dal.product.Create(new Product(0, "chocolateCake", 200, 15, Category.birthdayCakes));
        s_dal.product.Create(new Product(0, "calaCake", 180, 5, Category.barCakes));
        s_dal.product.Create(new Product(0, "cheesCake", 100, 20, Category.milkeyCakes));
        s_dal.product.Create(new Product(0, "tfilinCake", 110, 4, Category.barOrBatMitzva));
        s_dal.product.Create(new Product(0, "meorathimCake", 140, 8, Category.cakesCombinedWithPicture));
    }
    private static void createSale()
    {
        s_dal.sale.Create(new Sale(56, 0, 2, 220, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.sale.Create(new Sale(43, 0, 1, 165, false, DateTime.Now, DateTime.Now.AddMonths(1)));
        s_dal.sale.Create(new Sale(87, 0, 2, 320, true, DateTime.Now, DateTime.Now.AddMonths(1)));
        s_dal.sale.Create(new Sale(25, 0, 3, 570, false, DateTime.Now, DateTime.Now.AddMonths(1)));
        s_dal.sale.Create(new Sale(94, 0, 2, 300, true, DateTime.Now, DateTime.Now.AddMonths(1)));
    }
    private static void createCustomer()
    {
        s_dal.customer.Create(new Customer(467, "Miri", "Rabbi Yehudah Habbasie", "0534126521"));
        s_dal.customer.Create(new Customer(876, "Tzipi", "Sdey Chemed", "0527612265"));
        s_dal.customer.Create(new Customer(346, "Bati", "Avney Nezer", "0534126522"));
        s_dal.customer.Create(new Customer(6875, "Gili", "Netivot Hamishpat", "0556726659"));
        s_dal.customer.Create(new Customer(896, "Yaffi", "Netivot Hamishpat", "0556718372"));
    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        createCustomer();
        createProduct();
        createSale();
    }
}
