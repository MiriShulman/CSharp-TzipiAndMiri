using BO;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlTest;


    internal class Program
    {

        static readonly BlApi.IBL s_bl = BlApi.Factory.Get;

        public static void start()
        {
            string newOrder = "1";
            while (newOrder == "1")
            {
                BO.Order order = new BO.Order(tz(), null, 0);
                string continuOrder = "1";
                while (continuOrder == "1")
                {
                    AddProduct(order);

                    Console.WriteLine("לחץ 1 אם הינך רוצה להמשיך את ההזמנה ו - 0 אחרת");
                    continuOrder = Console.ReadLine();
                }


                Console.WriteLine("לחץ 1 אם הינך רוצה לעשות הזמנה נוספת ו - 0 אחרת");
                newOrder = Console.ReadLine();
            }

        }
        public static void AddProduct(BO.Order order)
        {
            Console.WriteLine("הכנס מזהה מוצר");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("הכנס כמות מוצר");
            int amount;
            int.TryParse(Console.ReadLine(), out amount);
            List<BO.SaleInProduct> sales = s_bl.Order.AddProductToOrder(order, id, amount);
            Console.WriteLine(string.Join(' ', sales));
            Console.Write("the total price already: ");
            Console.WriteLine(order.Price);
        }
        public static bool tz()
        {
            Console.WriteLine("הכנס ת.ז ");
            string tz = Console.ReadLine();
            if (tz == "0")
                return false;
            return true;
        }

        static void Main(string[] args)
        {
            DalTest.Initialization.Initialize();
            start();
        }


    }

