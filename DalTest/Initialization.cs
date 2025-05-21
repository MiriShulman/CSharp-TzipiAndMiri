using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;

    private static void createProduct()
    {
        s_dal.Product.Create(new Product(0, "chocolateCake", 200, 15, Category.birthdayCakes));
        s_dal.Product.Create(new Product(0, "calaCake", 180, 5, Category.barCakes));
        s_dal.Product.Create(new Product(0, "cheesCake", 100, 20, Category.milkeyCakes));
        s_dal.Product.Create(new Product(0, "tfilinCake", 110, 4, Category.barOrBatMitzva));
        s_dal.Product.Create(new Product(0, "meorathimCake", 140, 8, Category.cakesCombinedWithPicture));
    }
    private static void createSale()
    {
        s_dal.Sale.Create(new Sale(56, 0, 2, 220, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(43, 0, 1, 165, false, DateTime.Now, DateTime.Now.AddMonths(1)));
        s_dal.Sale.Create(new Sale(87, 0, 2, 320, true, DateTime.Now, DateTime.Now.AddMonths(1)));
        s_dal.Sale.Create(new Sale(25, 0, 3, 570, false, DateTime.Now, DateTime.Now.AddMonths(1)));
        s_dal.Sale.Create(new Sale(94, 0, 2, 300, true, DateTime.Now, DateTime.Now.AddMonths(1)));
    }
    private static void createCustomer()
    {
        s_dal.Customer.Create(new Customer(547556, "'[;ui]'", "Rabbi Yehudah Habbasie", "0534126521"));
        s_dal.Customer.Create(new Customer(321456, "r75e", "Sdey Chemed", "0527612265"));
        s_dal.Customer.Create(new Customer(64511, "ghvc j", "Avney Nezer", "0534126522"));
        s_dal.Customer.Create(new Customer(114856, "djm", "Netivot Hamishpat", "0556726659"));
        s_dal.Customer.Create(new Customer(86212, "yup", "Netivot Hamishpat", "0556718372"));
    }
    public static void Initialize()
    {
        s_dal = Factory.Get;
        Console.WriteLine(s_dal);
        createCustomer();
        createProduct();
        createSale();
        //return s_dal;
    }
}
