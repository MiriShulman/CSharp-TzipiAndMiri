using BlApi;
using BllImplementation;
using DalApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class delete : Form
    {
        string type;
        public delete(string str)
        {
            type = str;
            InitializeComponent();
        }

        private static IBL s_Ibl;

        private void del_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(enterId.Text, out id);
            switch (type)
            {
                case "product":
                    s_Ibl.Product.Delete(id);
                    break;
                case "customer":
                    s_Ibl.Customer.Delete(id);
                    break;
                case "sale":
                    s_Ibl.Sale.Delete(id);
                    break;
                default:
                    Console.WriteLine("this function on this type can't been");
                    break;
            }
        }

        private void id_Click(object sender, EventArgs e)
        {

        }
    }
}
