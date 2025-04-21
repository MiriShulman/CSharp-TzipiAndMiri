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

namespace client
{
    public partial class options : Form
    {
        string type;

        private static IDal s_dal = DalApi.Factory.Get;

        public options(string str)
        {
            type = str;
            InitializeComponent();
        }

        private void readAll_Click(object sender, EventArgs e)
        {
            ReadAll readAll = new ReadAll(type);
            readAll.Show();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete del = new delete(type);
            del.ShowDialog();
        }

        private void read_Click(object sender, EventArgs e)
        {
            Read read = new Read(type);
            read.ShowDialog();
        }
        private static IBL s_Ibl;

        private void update_Click(object sender, EventArgs e)
        {
            create_Or_Update("update");
        }

        private void create_Click(object sender, EventArgs e)
        {
            create_Or_Update("create");
        }
        private void create_Or_Update(string func)
        {
            switch (type)
            {
                case "product":
                    CreateOrUpdateProduct createProduct = new CreateOrUpdateProduct(func);
                    createProduct.ShowDialog();
                    break;
                case "customer":
                    CreateOrUpdateCustomer createCustomer = new CreateOrUpdateCustomer(func);
                    createCustomer.ShowDialog();
                    break;
                case "sale":
                    CreateOrUpdateSale createSale = new CreateOrUpdateSale(func);
                    createSale.ShowDialog();
                    break;
                default:
                    Console.WriteLine("this function on this type can't been");
                    break;
            }
        }
    }
}
