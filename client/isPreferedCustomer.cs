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

namespace client
{
    public partial class isPreferedCustomer : Form
    {
        private static IBL s_Ibl = BlApi.Factory.Get();
        public isPreferedCustomer()
        {
            InitializeComponent();
        }

        private void submitId_Click(object sender, EventArgs e)
        {
            Saleman s;

            if (radioButton1.Checked)
            {
                s = new Saleman(true);
            }
            else
                s = new Saleman(false);
            s.Show();
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void inpuId_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
