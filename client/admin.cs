using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace client
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            options o = new options("customer");
            o.Show();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            options o = new options("sale");
            o.Show();
        }

        private void products_Click(object sender, EventArgs e)
        {
            options o = new options("product");
            o.Show();
        }

        //private void products_Click(object sender, EventArgs e)
        //{
        //     function = new ("product");
        //    function.ShowDialog();
        //}

        //private void order_Click(object sender, EventArgs e)
        //{

        //}

    }
}
