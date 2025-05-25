using BlApi;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client;

public partial class ReadAll : Form
{
    private static IBL s_Ibl = BlApi.Factory.Get();

    string type;
    public ReadAll(string str)
    {
        type = str;
        InitializeComponent();
        //DalApi.ICrud crud;
        //List<T> items;
        //List<Product> products;
        //List<Sale> sales;
        //List<Customer> customers;

        switch (type)
        {
            case "product":
                list.DataSource = s_Ibl.Product.ReadAll();
                TList.Text = "list of products";
                break;
            case "customer":
                list.DataSource = s_Ibl.Customer.ReadAll();
                TList.Text = "list of customers";
                break;
            case "sale":
                list.DataSource = s_Ibl.Sale.ReadAll();
                TList.Text = "list of sales";
                break;
            default:
                Console.WriteLine("this function on this type can't been");
                break;
        }
        //switch (type)
        //{
        //    case "product":
        //        products = s_Ibl.Product.ReadAll();
        //        break;
        //    case "customer":
        //        customers = s_Ibl.Customer.ReadAll();
        //        break;
        //    case "sale":
        //        sales = s_Ibl.Sale.ReadAll();
        //        break;
        //    default:
        //        Console.WriteLine("this function on this type can't been");
        //        break;
        //}
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //switch (type)
        //{
        //    case "product":
        //        list.DataSource = s_Ibl.Product.ReadAll();
        //        TList.Text = "list of products";
        //        break;
        //    case "customer":
        //        list.DataSource = s_Ibl.Customer.ReadAll();
        //        TList.Text = "list of customers";
        //        break;
        //    case "sale":
        //        list.DataSource = s_Ibl.Sale.ReadAll();
        //        TList.Text = "list of sales";
        //        break;
        //    default:
        //        Console.WriteLine("this function on this type can't been");
        //        break;
        //}
    }

    private void salesListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
         
    }

    private void productsListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
