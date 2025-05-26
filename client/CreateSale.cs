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
//using static BO.

using BllImplementation;


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
        //private DalApi.IDal _dal = DalApi.Factory.Get;
        private static IBL s_Ibl = BlApi.Factory.Get();

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
                    s_Ibl.Sale.Create(s);
                    break;
                default:
                    s_Ibl.Sale.Update(s);
                    break;
            }
        }

        //private void sendIt_Click(object sender, EventArgs e)
        //{

        //}
    }
}
