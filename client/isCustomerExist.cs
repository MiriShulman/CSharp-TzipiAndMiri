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
using client;

namespace UI
{
    public partial class isCustomerExist : Form
    {
        private static IBL s_Ibl;
        public isCustomerExist()
        {
            InitializeComponent();
        }

        private void submitId_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(inpuId.Text, out id);
            if (s_Ibl.Customer.IsCustomerExist(id))
            {
                isExist.Text = "קיים לקוח כזה";

            }
            else
                isExist.Text = "לא קיים לקוח כזה";
        }
    }
}
