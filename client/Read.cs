using BlApi;
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

        private static IBL s_Ibl;

        private void find_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Console.ReadLine(), out id);
            switch (type)
            {
                case "product":
                    s_Ibl.Product.Read(id);
                    break;
                case "customer":
                    s_Ibl.Customer.Read(id);
                    break;
                case "sale":
                    s_Ibl.Sale.Read(id);
                    break;
                default:
                    Console.WriteLine("this function on this type can't been");
                    break;
            }
        }

    }
}
