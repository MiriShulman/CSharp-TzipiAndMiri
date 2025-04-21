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
    public partial class CreateOrUpdateProduct : Form
    {
        string funcName;
        public CreateOrUpdateProduct(string func)
        {
            funcName = func;
            InitializeComponent();
        }
        private static IProduct prod;

        private void sendIt_Click(object sender, EventArgs e)
        {
            string name = insertName.Text;
            int id = int.Parse(insertId.Text);
            int amount = (int) insertAmount.Value;
            double price = (double) insertAmount.Value;
            string str = chooseCategory.Text;
            Category category = Category.str;
            Product p = new Product(id, name, price, amount, category);
            switch (funcName)
            {
                case "create":
                    prod.Create(p);
                    break;
                default:
                    prod.Update(p);
                    break;
            }
        }
    }
    //private Category GetCategoryByName(string categoryName)
    //{
    //    // Assuming you have a list of categories
    //    List<Category> categories = GetCategories(); // Retrieve your categories
    //    return categories.FirstOrDefault(c => c.Name == categoryName); // Adjust based on your Category structure
    //}
}
