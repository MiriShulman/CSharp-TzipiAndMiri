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
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
        }

        private void buttonSaleMan_Click(object sender, EventArgs e)
        {
            saleMan s = new saleMan();
            s.Show();
        }
    }
}
