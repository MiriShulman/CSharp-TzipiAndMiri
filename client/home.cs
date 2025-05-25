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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            string parentDirectory = System.IO.Path.GetFullPath("Resources");
            string last = Path.GetFileName(parentDirectory);
            do
            {
                parentDirectory = Directory.GetParent(parentDirectory).FullName; // מקבל את התיקייה ההורה
                last = Path.GetFileName(parentDirectory);
            } while (last != "client");

            //string path = Path.Combine(parentDirectory, "xml", "products.xml");
            string picture = Path.Combine(parentDirectory, "Resources", "צילום מסך 2025-05-25 011956.jpg"+"");
            pictureBox1.Image = Image.FromFile(picture);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
        }

        private void buttonSaleMan_Click(object sender, EventArgs e)
        {
            isPreferedCustomer i = new isPreferedCustomer();
            i.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
