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
    public partial class enter : Form
    {
        public enter()
        {
            InitializeComponent();
        }

        private void products_Click(object sender, EventArgs e)
        {
            functions function = new functions("product");
            function.ShowDialog();
        }
    }
}
