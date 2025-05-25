using BO;

namespace client
{
    public partial class Saleman : Form
    {
        readonly BlApi.IBL s_Ibl = BlApi.Factory.Get();
        static Order? order;
        static List<Product?>? products;
        public Saleman(bool isPreferedCustomer)
        {
            InitializeComponent();
            order = new Order(isPreferedCustomer, [], 0);
            products = s_Ibl.Product.ReadAll();
            var categories = products
                .GroupBy(p => p!.c)
                .ToList();

            tbc.TabPages.Clear();

            foreach (var categoryGroup in categories)
            {
                TabPage? tab = new(categoryGroup.Key.ToString());
                DataGridView? dgv = new()
                {
                    Size = new Size(343, 200),
                    ColumnCount = 3
                };
                dgv.Columns[0].Name = "שם מוצר";
                dgv.Columns[0].ValueType = typeof(string);
                dgv.Columns[1].Name = "כמות במלאי";
                dgv.Columns[2].Name = "מחיר ליחידה";
                categoryGroup.ToList().ForEach(product => dgv.Rows.Add(product!.Name, product.Amount, product.Price));
                dgv.CellDoubleClick += (s, e) => SelectProduct(s, e);
                tab.Controls.Add(dgv);
                tbc.TabPages.Add(tab);
            }
            add.Visible = false;
            cntnud.Visible = false;
            nametxt.Visible = false;
        }

        private void SelectProduct(object? s, DataGridViewCellEventArgs e)
        {
            try
            {
                add.Visible = true;
                cntnud.Visible = true;
                nametxt.Visible = true;
                DataGridViewRow? row = (s as DataGridView)!.Rows[e.RowIndex];
                if (row != null)
                {
                    cntnud.Value = 1;
                    nametxt.Text = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button) != null)
                {
                    DataGridViewRow? row = choosedlb.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => !r.IsNewRow && r.Cells[0].Value != null && r.Cells[0].Value.ToString() == nametxt.Text);
                    if (row != null)
                    {
                        if ((sender as Button)!.Text == "עריכה")
                            SubTo(row);
                        else
                            EditTo(row);
                    }
                    else
                        AddTo();
                }
                add.Visible = false;
                cntnud.Visible = false;
                nametxt.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubTo(DataGridViewRow row)
        {
            try
            {
                var s = AddProduct(row.Cells[0].Value.ToString()!, Convert.ToInt32(cntnud.Value));
                sum.Text = s.Item2.ToString();
                row.Cells[1].Value = s.Item3.ProductBasePrice;
                row.Cells[2].Value = cntnud.Value;
                row.Cells[3].Value = (Convert.ToInt32(row.Cells[2].Value) * Convert.ToDouble(row.Cells[1].Value)).ToString();
                add.Text = "הוספה";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditTo(DataGridViewRow row)
        {
            try
            {
                var s = AddProduct(row.Cells[0].Value.ToString()!, Convert.ToInt32(cntnud.Value) + Convert.ToInt32(row.Cells[2].Value));
                sum.Text = s.Item2.ToString();
                row.Cells[1].Value = s.Item3.ProductBasePrice.ToString();
                row.Cells[2].Value = cntnud.Value + Convert.ToInt32(row.Cells[2].Value);
                row.Cells[3].Value = (Convert.ToInt32(row.Cells[2].Value) * s.Item3.ProductBasePrice).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private (double?, double?, ProductInOrder) AddProduct(string name, int cnt)
        {
            try
            {
                double? finalPrice = order!.Price;
                ProductInOrder product = order.ProductsInOrder!.First(p => p.ProductName == name);
                order.ProductsInOrder!.Remove(product);
                s_Ibl.Order.AddProductToOrder(order, product.ProductId, cnt);
                return (finalPrice, order!.Price, product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return (0, 0, new ProductInOrder(0, "", 0, 0, null, 0));
            }
        }
        private void AddTo()
        {
            try
            {
                Product? product = products!.FirstOrDefault(p => p!.Name == nametxt.Text);
                s_Ibl.Order.AddProductToOrder(order!, product!.Identity, (int)cntnud.Value);
                choosedlb.Rows.Add(nametxt.Text, order!.ProductsInOrder!.Last().ProductBasePrice, cntnud.Value, order.ProductsInOrder!.Last().TotalSum);
                sum.Text = order.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditProduct(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nametxt.Visible = true;
                add.Visible = true;
                cntnud.Visible = true;
                if (sender is Button btn)
                {
                    if (btn.Parent is Panel panel)
                    {
                        Label? lblName = panel.Controls.OfType<Label>().FirstOrDefault();
                        NumericUpDown? numQty = panel.Controls.OfType<NumericUpDown>().FirstOrDefault();

                        if (lblName != null && numQty != null)
                        {
                            nametxt.Text = lblName.Text;
                            cntnud.Value = numQty.Value;
                            add.Tag = panel;
                        }
                    }
                }
                else
                {
                    DataGridViewRow? row = (sender as DataGridView)!.Rows[e.RowIndex];
                    if (row != null)
                    {
                        cntnud.Value = Convert.ToUInt32(row.Cells[2].Value);
                        nametxt.Text = row.Cells[0].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Choosedlb_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            add.Text = "עריכה";
            EditProduct(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s_Ibl.Order.DoOrder(order!);
            MessageBox.Show("ההזמנה בוצעה בהצלחה! \n הסכום לתשלום " + order.Price + ".\n תודה שבחרתם בנו!", "סיום הזמנה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            this.Close();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
