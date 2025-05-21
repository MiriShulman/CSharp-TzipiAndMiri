namespace client
{
    partial class SearchSaleForProduct
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
            idLabel = new Label();
            nameLabel = new Label();
            priceLabe = new Label();
            amountLabel = new Label();
            nameInpt = new TextBox();
            label1 = new Label();
            IsPreferredCustomer = new CheckBox();
            listOfSales = new ListBox();
            search = new Button();
            idInput = new NumericUpDown();
            priceInput = new NumericUpDown();
            amountInput2 = new NumericUpDown();
            categoryInput = new ComboBox();
            categoryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)idInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountInput2).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(711, 111);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(49, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Insert id";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(548, 111);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(69, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "insert name";
            nameLabel.Click += nameLabel_Click;
            // 
            // priceLabe
            // 
            priceLabe.AutoSize = true;
            priceLabe.Location = new Point(411, 111);
            priceLabe.Name = "priceLabe";
            priceLabe.Size = new Size(65, 15);
            priceLabe.TabIndex = 2;
            priceLabe.Text = "insert price";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(697, 218);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(81, 15);
            amountLabel.TabIndex = 3;
            amountLabel.Text = "insert amount";
            // 
            // nameInpt
            // 
            nameInpt.Location = new Point(548, 155);
            nameInpt.Name = "nameInpt";
            nameInpt.Size = new Size(80, 23);
            nameInpt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(324, 37);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 10;
            label1.Text = "SearchSaleForProduct";
            // 
            // IsPreferredCustomer
            // 
            IsPreferredCustomer.AutoSize = true;
            IsPreferredCustomer.Font = new Font("Segoe UI", 10F);
            IsPreferredCustomer.Location = new Point(580, 357);
            IsPreferredCustomer.Name = "IsPreferredCustomer";
            IsPreferredCustomer.Size = new Size(160, 23);
            IsPreferredCustomer.TabIndex = 11;
            IsPreferredCustomer.Text = "IsPreferredCustomer?";
            IsPreferredCustomer.UseVisualStyleBackColor = true;
            // 
            // listOfSales
            // 
            listOfSales.FormattingEnabled = true;
            listOfSales.ItemHeight = 15;
            listOfSales.Location = new Point(85, 106);
            listOfSales.Name = "listOfSales";
            listOfSales.Size = new Size(182, 274);
            listOfSales.TabIndex = 12;
            listOfSales.SelectedIndexChanged += listOfSales_SelectedIndexChanged;
            // 
            // search
            // 
            search.Location = new Point(401, 357);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 13;
            search.Text = "חפש";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // idInput
            // 
            idInput.Location = new Point(689, 156);
            idInput.Name = "idInput";
            idInput.Size = new Size(99, 23);
            idInput.TabIndex = 14;
            idInput.ValueChanged += idInput_ValueChanged;
            // 
            // priceInput
            // 
            priceInput.Location = new Point(376, 156);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(120, 23);
            priceInput.TabIndex = 15;
            // 
            // amountInput2
            // 
            amountInput2.Location = new Point(689, 265);
            amountInput2.Name = "amountInput2";
            amountInput2.Size = new Size(120, 23);
            amountInput2.TabIndex = 16;
            // 
            // categoryInput
            // 
            categoryInput.FormattingEnabled = true;
            categoryInput.Location = new Point(519, 265);
            categoryInput.Name = "categoryInput";
            categoryInput.Size = new Size(121, 23);
            categoryInput.TabIndex = 9;
            categoryInput.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(535, 218);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(85, 15);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "insert category";
            // 
            // SearchSaleForProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 451);
            Controls.Add(amountInput2);
            Controls.Add(priceInput);
            Controls.Add(idInput);
            Controls.Add(search);
            Controls.Add(listOfSales);
            Controls.Add(IsPreferredCustomer);
            Controls.Add(label1);
            Controls.Add(categoryInput);
            Controls.Add(nameInpt);
            Controls.Add(categoryLabel);
            Controls.Add(amountLabel);
            Controls.Add(priceLabe);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Name = "SearchSaleForProduct";
            Text = "SearchSaleForProduct";
            Load += SearchSaleForProduct_Load;
            ((System.ComponentModel.ISupportInitialize)idInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountInput2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label nameLabel;
        private Label priceLabe;
        private Label amountLabel;
        private TextBox nameInpt;
        private TextBox amountInput;
        private Label label1;
        private CheckBox IsPreferredCustomer;
        private ListBox listOfSales;
        private Button search;
        private NumericUpDown idInput;
        private NumericUpDown priceInput;
        private NumericUpDown amountInput2;
        private ComboBox categoryInput;
        private Label categoryLabel;
        //private NumericUpDown amountInput;
        //private NumericUpDown amountInput;
    }
}