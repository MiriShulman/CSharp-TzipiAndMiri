namespace client
{
    partial class Saleman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbc = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            cntnud = new NumericUpDown();
            nametxt = new TextBox();
            add = new Button();
            panel1 = new Panel();
            sum = new Label();
            choosedlb = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            pricetoone = new DataGridViewTextBoxColumn();
            count = new DataGridViewTextBoxColumn();
            priceTotal = new DataGridViewTextBoxColumn();
            tbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cntnud).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)choosedlb).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(388, 25);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 0;
            label1.Text = "הזמנה";
            label1.Click += label1_Click;
            // 
            // tbc
            // 
            tbc.Controls.Add(tabPage1);
            tbc.Controls.Add(tabPage2);
            tbc.Location = new Point(593, 58);
            tbc.Margin = new Padding(3, 2, 3, 2);
            tbc.Name = "tbc";
            tbc.RightToLeft = RightToLeft.Yes;
            tbc.SelectedIndex = 0;
            tbc.Size = new Size(370, 232);
            tbc.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(362, 204);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(362, 204);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(46, 237);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(218, 28);
            button1.TabIndex = 2;
            button1.Text = "לסיום הזמנה ולתשלום סופי";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(158, 182);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "סך הכל:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(892, 31);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "בחר מוצר:";
            // 
            // cntnud
            // 
            cntnud.Location = new Point(455, 169);
            cntnud.Margin = new Padding(3, 2, 3, 2);
            cntnud.Name = "cntnud";
            cntnud.Size = new Size(86, 23);
            cntnud.TabIndex = 7;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(449, 120);
            nametxt.Margin = new Padding(3, 2, 3, 2);
            nametxt.Name = "nametxt";
            nametxt.ReadOnly = true;
            nametxt.Size = new Size(104, 23);
            nametxt.TabIndex = 8;
            nametxt.TextChanged += nametxt_TextChanged;
            // 
            // add
            // 
            add.Location = new Point(450, 206);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.Size = new Size(101, 34);
            add.TabIndex = 9;
            add.Tag = "";
            add.Text = "להוספה";
            add.UseVisualStyleBackColor = true;
            add.Click += Add_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(sum);
            panel1.Controls.Add(choosedlb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cntnud);
            panel1.Controls.Add(tbc);
            panel1.Controls.Add(nametxt);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(add);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            panel1.Location = new Point(10, 66);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 304);
            panel1.TabIndex = 14;
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            sum.Location = new Point(88, 182);
            sum.Name = "sum";
            sum.Size = new Size(18, 20);
            sum.TabIndex = 13;
            sum.Text = "0";
            // 
            // choosedlb
            // 
            choosedlb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            choosedlb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            choosedlb.Columns.AddRange(new DataGridViewColumn[] { name, pricetoone, count, priceTotal });
            choosedlb.Location = new Point(12, 18);
            choosedlb.Margin = new Padding(3, 2, 3, 2);
            choosedlb.Name = "choosedlb";
            choosedlb.RightToLeft = RightToLeft.Yes;
            choosedlb.RowHeadersWidth = 51;
            choosedlb.Size = new Size(373, 141);
            choosedlb.TabIndex = 12;
            choosedlb.CellDoubleClick += Choosedlb_CellDoubleClick;
            // 
            // name
            // 
            name.HeaderText = "שם מוצר";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 81;
            // 
            // pricetoone
            // 
            pricetoone.HeaderText = "מחיר ליחידה";
            pricetoone.MinimumWidth = 6;
            pricetoone.Name = "pricetoone";
            pricetoone.ReadOnly = true;
            pricetoone.Width = 99;
            // 
            // count
            // 
            count.HeaderText = "כמות";
            count.MinimumWidth = 6;
            count.Name = "count";
            count.ReadOnly = true;
            count.Width = 60;
            // 
            // priceTotal
            // 
            priceTotal.HeaderText = "מחיר כולל";
            priceTotal.MinimumWidth = 6;
            priceTotal.Name = "priceTotal";
            priceTotal.ReadOnly = true;
            priceTotal.Width = 87;
            // 
            // Saleman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1002, 379);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Saleman";
            Text = "Saleman";
            tbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cntnud).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)choosedlb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tbc;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Label label2;
        private Label label3;
        private NumericUpDown cntnud;
        private TextBox nametxt;
        private Button add;
        private Panel panel1;
        private DataGridView choosedlb;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn pricetoone;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn priceTotal;
        private Label sum;
    }
}