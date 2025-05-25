using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Read : Form
    {
        string type;
        public Read(string str)
        {
            type = str;
            InitializeComponent();
        }

        private static IBL s_Ibl = BlApi.Factory.Get();

        private void find_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(enterId.Text, out id);
            switch (type)
            {
                case "product":
                    Product p =  s_Ibl.Product.Read(id);
                    insert_me.Text = p.ToString();
                    break;
                case "customer":
                    Customer c = s_Ibl.Customer.Read(id);
                    insert_me.Text = c.ToString();
                    break;
                case "sale":
                    Sale s = s_Ibl.Sale.Read(id);
                    insert_me.Text = s.ToString();
                    break;
                default:
                    Console.WriteLine("this function on this type can't been");
                    break;
            }
        }

        private void enterId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
