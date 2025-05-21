using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using BO;
namespace client
{
    public partial class SearchSaleForProduct : Form
    {
        private static IBL s_Ibl;
        public SearchSaleForProduct()
        {
            InitializeComponent();

            categoryInput.Items.Add("birthdayCakes");
            categoryInput.Items.Add("barCakes");
            categoryInput.Items.Add("barOrBatMitzva");
            categoryInput.Items.Add("milkeyCakes");
            categoryInput.Items.Add("cakesCombinedWithPicture");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string name = nameInpt.Text;
            int id = int.Parse(idInput.Text);
            int amount = int.Parse(amountInput.Text);
            double price = (double)priceInput.Value;
            Category category = (Category)Enum.Parse(typeof(Category), categoryInput.SelectedItem.ToString());
            bool isPreferredCustomer = IsPreferredCustomer.Checked;
            Product p = new Product(id, name, price, amount, category);
            s_Ibl.Order.SearchSaleForProduct(, isPreferredCustomer);
            listOfSales.Items.Add();
        }

        private void idInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listOfSales_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SearchSaleForProduct_Load(object sender, EventArgs e)
        {

        }

        //private void search_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
