using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class CreateOrUpdateCustomer : Form
    {
        string funcName;

        private static ICustomer customer;
        public CreateOrUpdateCustomer(string func)
        {
            funcName = func;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendItCustomer_Click(object sender, EventArgs e)
        {
            string name = fillCustomerName.Text;
            int id = int.Parse(fillCustomerId.Text);
            string address = fillAddressCustomer.Text;
            string phone = fillPhoneCustomer.Text;
            Customer p = new Customer(id, name, address, phone);
            switch (funcName)
            {
                case "create":
                    customer.Create(p);
                    break;
                default:
                    customer.Update(p);
                    break;
            }
        }

        private void customerId_Click(object sender, EventArgs e)
        {

        }
    }
}
