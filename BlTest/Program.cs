using BO;
using System.Collections.Generic;
using System.Diagnostics;
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
                    Console.WriteLine("press 1 if do you want continue your's order, else press 0 ");
                    continuOrder = Console.ReadLine();
                }

                Console.WriteLine("press 1 if did you want invite again, else press 0");
                newOrder = Console.ReadLine();
            }

        }
        public static void AddProduct(BO.Order order)
        {
            Console.WriteLine("insert product id");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("insert anount of products");
            int amount;
            int.TryParse(Console.ReadLine(), out amount);
            List<BO.SaleInProduct> sales = s_bl.Order.AddProductToOrder(order, id, amount);
            Console.WriteLine(string.Join(' ', sales));
            Console.Write("the total price already: ");
            Console.WriteLine(order.Price);
        }
        public static bool tz()
        {
            Console.WriteLine("insert id");
            string tz = Console.ReadLine();
            if (tz == "0")
                return false;
            return true;
        }

        static void Main(string[] args)
        {
        int press;
        Console.WriteLine("if you want to initialize press 1, else press 0");
            if (int.TryParse(Console.ReadLine(), out press))
            {
                //int.TryParse(Console.ReadLine(), out press);
                if (press == 1)
                    DalTest.Initialization.Initialize();
                start();
            }
        }


    }

