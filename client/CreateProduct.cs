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
        private static IBL s_Ibl = BlApi.Factory.Get();

        string funcName;
        public CreateOrUpdateProduct(string func)
        {
            funcName = func;
            InitializeComponent();
            var categories = Enum.GetValues(typeof(Category)).Cast<Category>().Select(p => p.ToString()).ToList();

            // הגדרת המקור של הקומבובוקס
            chooseCategory.DataSource = categories;
        }
        //private static IProduct prod;

        private void sendIt_Click(object sender, EventArgs e)
        {
            string name = insertName.Text;
            int id = int.Parse(insertId.Text);
            int amount = (int)insertAmount.Value;
            double price = (double)insertPrice.Value;
            string selectedCategoryName = chooseCategory.SelectedItem.ToString();
            Enum.TryParse<BO.Category>(selectedCategoryName, out BO.Category selectedCategory);

            Product p = new Product(id, name, price, amount, selectedCategory);
            switch (funcName)
            {
                case "create":
                    s_Ibl.Product.Create(p);
                    break;
                default:
                    s_Ibl.Product.Update(p);
                    break;
            }
        }

        private void CreateOrUpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void chooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    //private Category GetCategoryByName(string categoryName)
    //{
    //    // Assuming you have a list of categories
    //    List<Category> categories = GetCategories(); // Retrieve your categories
    //    return categories.FirstOrDefault(c => c.Name == categoryName); // Adjust based on your Category structure
    //}
}
