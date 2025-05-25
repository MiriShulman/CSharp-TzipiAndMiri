namespace client
{
    partial class CreateOrUpdateProduct
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
            name = new Label();
            price = new Label();
            category = new Label();
            insertName = new TextBox();
            insertPrice = new NumericUpDown();
            chooseCategory = new ComboBox();
            amount = new Button();
            insertAmount = new NumericUpDown();
            salesOfProduct = new ListBox();
            SaleInProduct = new Label();
            sendIt = new Button();
            id = new Label();
            insertId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)insertPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)insertAmount).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(687, 58);
            name.Name = "name";
            name.Size = new Size(46, 20);
            name.TabIndex = 0;
            name.Text = "name";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(532, 58);
            price.Name = "price";
            price.Size = new Size(42, 20);
            price.TabIndex = 1;
            price.Text = "price";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(353, 58);
            category.Name = "category";
            category.Size = new Size(67, 20);
            category.TabIndex = 2;
            category.Text = "category";
            // 
            // insertName
            // 
            insertName.Location = new Point(663, 83);
            insertName.Name = "insertName";
            insertName.Size = new Size(125, 27);
            insertName.TabIndex = 3;
            // 
            // insertPrice
            // 
            insertPrice.Location = new Point(488, 84);
            insertPrice.Name = "insertPrice";
            insertPrice.Size = new Size(150, 27);
            insertPrice.TabIndex = 4;
            // 
            // chooseCategory
            // 
            chooseCategory.FormattingEnabled = true;
            chooseCategory.Location = new Point(308, 84);
            chooseCategory.Name = "chooseCategory";
            chooseCategory.Size = new Size(151, 28);
            chooseCategory.TabIndex = 5;
            chooseCategory.SelectedIndexChanged += chooseCategory_SelectedIndexChanged;
            // 
            // amount
            // 
            amount.AccessibleRole = AccessibleRole.None;
            amount.BackColor = Color.WhiteSmoke;
            amount.Location = new Point(168, 54);
            amount.Name = "amount";
            amount.Size = new Size(94, 29);
            amount.TabIndex = 6;
            amount.Text = "amount";
            amount.UseVisualStyleBackColor = false;
            // 
            // insertAmount
            // 
            insertAmount.Location = new Point(137, 89);
            insertAmount.Name = "insertAmount";
            insertAmount.Size = new Size(150, 27);
            insertAmount.TabIndex = 7;
            // 
            // salesOfProduct
            // 
            salesOfProduct.FormattingEnabled = true;
            salesOfProduct.ItemHeight = 20;
            salesOfProduct.Location = new Point(583, 184);
            salesOfProduct.Name = "salesOfProduct";
            salesOfProduct.Size = new Size(150, 104);
            salesOfProduct.TabIndex = 8;
            // 
            // SaleInProduct
            // 
            SaleInProduct.AutoSize = true;
            SaleInProduct.Location = new Point(598, 161);
            SaleInProduct.Name = "SaleInProduct";
            SaleInProduct.Size = new Size(108, 20);
            SaleInProduct.TabIndex = 9;
            SaleInProduct.Text = "Sale In Product";
            // 
            // sendIt
            // 
            sendIt.BackColor = Color.Coral;
            sendIt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sendIt.ForeColor = SystemColors.ButtonFace;
            sendIt.Location = new Point(308, 259);
            sendIt.Name = "sendIt";
            sendIt.Size = new Size(128, 54);
            sendIt.TabIndex = 10;
            sendIt.Text = "send it";
            sendIt.UseVisualStyleBackColor = false;
            sendIt.Click += sendIt_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(48, 53);
            id.Name = "id";
            id.Size = new Size(22, 20);
            id.TabIndex = 11;
            id.Text = "id";
            // 
            // insertId
            // 
            insertId.Location = new Point(6, 89);
            insertId.Name = "insertId";
            insertId.Size = new Size(125, 27);
            insertId.TabIndex = 12;
            // 
            // CreateOrUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(insertId);
            Controls.Add(id);
            Controls.Add(sendIt);
            Controls.Add(SaleInProduct);
            Controls.Add(salesOfProduct);
            Controls.Add(insertAmount);
            Controls.Add(amount);
            Controls.Add(chooseCategory);
            Controls.Add(insertPrice);
            Controls.Add(insertName);
            Controls.Add(category);
            Controls.Add(price);
            Controls.Add(name);
            ForeColor = Color.DarkOrange;
            Name = "CreateOrUpdateProduct";
            Text = "Create or update product";
            Load += CreateOrUpdateProduct_Load;
            ((System.ComponentModel.ISupportInitialize)insertPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)insertAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label price;
        private Label category;
        private TextBox insertName;
        private NumericUpDown insertPrice;
        private ComboBox chooseCategory;
        private Button amount;
        private NumericUpDown insertAmount;
        private ListBox salesOfProduct;
        private Label SaleInProduct;
        private Button sendIt;
        private Label id;
        private TextBox insertId;
    }
}