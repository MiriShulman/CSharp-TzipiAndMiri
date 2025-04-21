using BlApi;
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
    private static IBL s_Ibl;

    string type;
    public ReadAll(string str)
    {
        type = str;
        InitializeComponent();
        //DalApi.ICrud<T> crud;
        List<T> items;

        switch (type)
        {
            case "product":
                items = s_Ibl.Product.ReadAll();
                break;
            case "customer":
                items = s_Ibl.Customer.ReadAll();
                break;
            case "sale":
                items = s_Ibl.Sale.ReadAll();
                break;
            default:
                Console.WriteLine("this function on this type can't been");
                break;
        }
    }
    
}
