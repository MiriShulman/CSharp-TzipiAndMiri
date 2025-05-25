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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace client
{
    public partial class CreateOrUpdateSale : Form
    {
        string funcName;
        Boolean isNeedClubTemp;
        public CreateOrUpdateSale(string func)
        {
            funcName = func;
            InitializeComponent();
        }
        private static ISale sale;
        private void sendIt_Click(object sender, EventArgs e, object isNeedClubSale)
        {
            int code = int.Parse(fillSaleCode.Text);
            int id = int.Parse(fillIdSale.Text);
            int minimumAmount = (int)fillMinimumAmountSale.Value;
            double sum = (double)fillSumSale.Value;
            DateTime beginSale = fillBeginSale.Value;
            DateTime endSale = fillEndSale.Value;
            Sale s = new Sale(code, id, minimumAmount, sum, isNeedClubTemp, beginSale, endSale);
            switch (funcName)
            {
                case "create":
                    sale.Create(s);
                    break;
                default:
                    sale.Update(s);
                    break;
            }


        }

        private void isNeedClub_CheckedChanged(object sender, EventArgs e)
        {
            // לבדוק איזו אופציה נבחרה ולהכניס את הבחירה למשתנה הבוליאני
            if (isNeedClub.Checked)
            {
                isNeedClubTemp = true; // אם "כן" נבחר
            }
            else if (isNeedClub.Checked)
            {
                isNeedClubTemp = false; // אם "לא" נבחר
            }
        }

        private void sendItSale_Click(object sender, EventArgs e)
        {

        }
    }
}
