
using DalApi;
using DO;
using DalTest;
using System.IO;
using System.Diagnostics;

namespace Dal
{

    //כרגע הבעיה שהוא הולך לניתוב לא נכון בקריאה מקובץ הלוג, 
    //'Z:\B\שולמן מירי\c#\CSharp-TzipiAndMiri\bin\products.xml
    internal class program

    {
        private static readonly IDal s_dal = DalApi.Factory.Get;

        private static void CreateProduct()
        {
            Console.WriteLine($"to add birthdayCakes press 1");
            Console.WriteLine($"to add barCakes press 2");
            Console.WriteLine($"to add barOrBatMitzva press 3");
            Console.WriteLine($"to add milkeyCakes press 4");
            Console.WriteLine($"to add cakesCombinedWithPicture press 5");
            Console.WriteLine("to go back press 0");
            int select;
            int.TryParse(Console.ReadLine(), out select);
            Category cat = (Category)select;
            Console.WriteLine("insert name of cake");
            string name = Console.ReadLine();
            Console.WriteLine("insert price of cake");
            double price;
            double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("insert amount of cake");
            int amount;
            int.TryParse(Console.ReadLine(), out amount);
            Product prod = new Product(0, name, price, amount, cat);
            Console.WriteLine(s_dal.Product.Create(prod));
        }

        private static void CreateCustomer()
        {
            Console.WriteLine("insert name of your customer");
            string name = Console.ReadLine();
            Console.WriteLine("insert address of your customer");
            string address = Console.ReadLine();
            Console.WriteLine("insert phone of your customer");
            string phone = Console.ReadLine();
            Customer customer = new Customer(0, name, address, phone);
            Console.WriteLine(s_dal.Customer.Create(customer));
        }

        private static void CreateSale()
        {
            Console.WriteLine("insert id of your sale");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("insert minimumAmount of your sale");
            int minimumAmount;
            int.TryParse(Console.ReadLine(), out minimumAmount);
            Console.WriteLine("insert sum of your sale");
            double sum;
            double.TryParse(Console.ReadLine(), out sum);
            Console.WriteLine("insert 1 of your sale need club and 2 if not");
            int isNeedClubTemp;
            int.TryParse(Console.ReadLine(), out isNeedClubTemp);
            bool isNeedClub;
            if (isNeedClubTemp == 1)
                isNeedClub = true;
            else
                isNeedClub = false;
            Console.WriteLine("in how many dayes will the sale start?");
            int beginSaleTemp;
            int.TryParse(Console.ReadLine(), out beginSaleTemp);
            DateTime beginSale;
            beginSale = DateTime.Now.AddDays(beginSaleTemp);
            Console.WriteLine("how many days is the sale?");
            int endSaleTemp;
            int.TryParse(Console.ReadLine(), out endSaleTemp);
            DateTime endSale;
            endSale = beginSale.AddDays(endSaleTemp);
            Sale sale = new Sale(0, id, minimumAmount, sum, isNeedClub, beginSale, endSale);
            Console.WriteLine(s_dal.Sale.Create(sale));

        }

        private static void Read<T>(ICrud<T> crud)
        {
            try
            {
                int id;
                Console.WriteLine("insert id of your item");
                int.TryParse(Console.ReadLine(), out id);
                Console.WriteLine(crud.Read(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static void ReadAll<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("i'm here");
                List<T> list = crud.ReadAll();
                Console.WriteLine("i'm here");

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("i arrive to readAll");
                Console.WriteLine(ex);
            }
        }

        private static void Delete<T>(ICrud<T> crud)
        {
            Console.WriteLine("insert id's" + crud + " to delete him");
            try
            {
                int id;
                int.TryParse(Console.ReadLine(), out id);
                crud.Delete(id);
            }
            catch
            {
                throw new DalIdNotExist("this id is not exsist");
            }
        }

        private static void updateProduct()
        {
            int id;
            Console.WriteLine("insert id, name, price, amount");
            int.TryParse(Console.ReadLine(), out id);
            string name = Console.ReadLine();
            double price;
            double.TryParse(Console.ReadLine(), out price);
            int amount;
            int.TryParse(Console.ReadLine(), out amount);
            Product prod = new Product(id, name, price, amount);
            s_dal.Product.Update(prod);
        }

        private static void updateCustomer()
        {
            Console.WriteLine("insert id, name, address, phone");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string phone = Console.ReadLine();
            Customer customer = new Customer(id, name, address, phone);
            s_dal.Customer.Update(customer);
        }

        private static void updateSale()
        {
            Console.WriteLine("insert id, code, min, sum, is need club");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            int code;
            int.TryParse(Console.ReadLine(), out code);
            int minimumAmount;
            int.TryParse(Console.ReadLine(), out minimumAmount);
            double sum;
            double.TryParse(Console.ReadLine(), out sum);
            bool isNeedClub;
            bool.TryParse(Console.ReadLine(), out isNeedClub);
            DateTime beginSale;
            beginSale = DateTime.Now;
            //DateTime.TryParse(Console.ReadLine(), out beginSale);
            DateTime endSale;
            endSale = DateTime.Now.AddDays(20);
            //DateTime.TryParse(Console.ReadLine(), out endSale);
            Sale sale = new Sale(code, id, minimumAmount, sum, isNeedClub, beginSale, endSale);
            s_dal.Sale.Update(sale);

        }

        private static void MainMenu()
        {
            int press;
            do
            {
                Console.WriteLine("for products press 1");
                Console.WriteLine("for sales press 2");
                Console.WriteLine("for customers press 3");
                Console.WriteLine("for delete the log dir press 4");
                Console.WriteLine("for exit press 0");
                if (!int.TryParse(Console.ReadLine(), out press))
                    press = 0;
                if (press == 4)
                    Tools.LogManager.DeleteLog();
                if (press > 4)
                    throw new DalIsNotOption("this option is not exist");
                if (press != 4 && press != 0)
                    chooseMenu(press);
            } while (press != 0);
        }

        private static int SubMenu(string item)
        {
            int press;
            Console.WriteLine($"to add {item} press 1");
            Console.WriteLine($"to read one {item} press 2");
            Console.WriteLine($"to read all {item} press 3");
            Console.WriteLine($"to update {item} press 4");
            Console.WriteLine($"to delete {item} press 5");
            Console.WriteLine("to go back press 0");
            if (!int.TryParse(Console.ReadLine(), out press))
                press = 6;
            if (press == 0)
                MainMenu();
            if (press > 5)
                throw new DalIsNotOption("this option is not exist");
            return press;
        }

        
        private static void ProductMenu(int press)
        {
            switch (press)
            {
                case 1:
                    {
                        CreateProduct();
                        break;
                    }

                case 2:
                    {
                        Read<Product>(s_dal.Product);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("product menu");
                        //Console.WriteLine(s_dal);
                        //Console.WriteLine(s_dal.Product);
                        ReadAll<Product>(s_dal.Product);
                        break;
                    }
                case 4:
                    {
                        updateProduct();
                        break;
                    }
                case 5:
                    {
                        Delete<Product>(s_dal.Product);
                        break;
                    }
                
            }
        }
        private static void CustomerMenu(int press)
        {
            switch (press)
            {
                case 1:
                    {
                        CreateCustomer();
                        break;
                    }

                case 2:
                    {
                        Read<Customer>(s_dal.Customer);
                        break;
                    }
                case 3:
                    {
                        ReadAll<Customer>(s_dal.Customer);
                        break;
                    }
                case 4:
                    {
                        updateCustomer();
                        break;
                    }
                case 5:
                    {
                        Delete<Customer>(s_dal.Customer);
                        break;
                    }
            }
        }

        private static void SaleMenu(int press)
        {
            switch (press)
            {
                case 1:
                    {
                        CreateSale();
                        break;
                    }

                case 2:
                    {
                        Read<Sale>(s_dal.Sale);
                        break;
                    }
                case 3:
                    {
                        ReadAll<Sale>(s_dal.Sale);
                        break;
                    }
                case 4:
                    {
                        updateSale();
                        break;
                    }
                case 5:
                    {
                        Delete<Sale>(s_dal.Sale);
                        break;
                    }
            }
        }
        private static void chooseMenu(int press)
        {

            switch (press)
            {
                case 1:
                    {
                        press = SubMenu("product");
                        ProductMenu(press);
                        break;
                    }

                case 2:
                    {
                        press = SubMenu("sale");
                        SaleMenu(press);
                        break;
                    }
                case 3:
                    {
                        press = SubMenu("customer");
                        CustomerMenu(press);
                        break;
                    }
            }
        }
        public static void Main(string[] args)
        {
            int press;
            Console.WriteLine();
            //String dirPath = Directory.GetCurrentDirectory() + @"\Log";
            int month = DateTime.Now.Month;
            //string[] foldersEntries = Directory.GetDirectories(@"C:\Users\1\Desktop\new");
            //Console.WriteLine(foldersEntries[0]);
            String currentPath;
            Console.WriteLine("if you want to initialize press 1, else press 0");
            //while (press != 0 && press != 1)
            //{
            if (int.TryParse(Console.ReadLine(), out press))
            {
                //int.TryParse(Console.ReadLine(), out press);
                if (press == 1)
                    Initialization.Initialize();
                else if (press == 0)
                {
                    
                    //Console.WriteLine(xmlPath);
                    Console.WriteLine(press);
                }
                //if (press!= 1 && press !=0)
                //    Console.WriteLine("try again");
            }
            else
            {
                
                //s_dal = DalApi.Factory.Get;
                Console.WriteLine("Invalid input, try again.");
            }
            //}


            try
            {
                MainMenu();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("this option not exist");
                Console.WriteLine(ex.Message);
            }
        }
    }
        
}

