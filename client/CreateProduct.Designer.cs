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
            name.Location = new Point(601, 44);
            name.Name = "name";
            name.Size = new Size(37, 15);
            name.TabIndex = 0;
            name.Text = "name";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(466, 44);
            price.Name = "price";
            price.Size = new Size(33, 15);
            price.TabIndex = 1;
            price.Text = "price";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(309, 44);
            category.Name = "category";
            category.Size = new Size(53, 15);
            category.TabIndex = 2;
            category.Text = "category";
            // 
            // insertName
            // 
            insertName.Location = new Point(580, 62);
            insertName.Margin = new Padding(3, 2, 3, 2);
            insertName.Name = "insertName";
            insertName.Size = new Size(110, 23);
            insertName.TabIndex = 3;
            // 
            // insertPrice
            // 
            insertPrice.Location = new Point(427, 63);
            insertPrice.Margin = new Padding(3, 2, 3, 2);
            insertPrice.Name = "insertPrice";
            insertPrice.Size = new Size(131, 23);
            insertPrice.TabIndex = 4;
            // 
            // chooseCategory
            // 
            chooseCategory.FormattingEnabled = true;
            chooseCategory.Location = new Point(270, 63);
            chooseCategory.Margin = new Padding(3, 2, 3, 2);
            chooseCategory.Name = "chooseCategory";
            chooseCategory.Size = new Size(133, 23);
            chooseCategory.TabIndex = 5;
            // 
            // amount
            // 
            amount.Location = new Point(147, 40);
            amount.Margin = new Padding(3, 2, 3, 2);
            amount.Name = "amount";
            amount.Size = new Size(82, 22);
            amount.TabIndex = 6;
            amount.Text = "amount";
            amount.UseVisualStyleBackColor = true;
            // 
            // insertAmount
            // 
            insertAmount.Location = new Point(120, 67);
            insertAmount.Margin = new Padding(3, 2, 3, 2);
            insertAmount.Name = "insertAmount";
            insertAmount.Size = new Size(131, 23);
            insertAmount.TabIndex = 7;
            // 
            // salesOfProduct
            // 
            salesOfProduct.FormattingEnabled = true;
            salesOfProduct.ItemHeight = 15;
            salesOfProduct.Location = new Point(510, 138);
            salesOfProduct.Margin = new Padding(3, 2, 3, 2);
            salesOfProduct.Name = "salesOfProduct";
            salesOfProduct.Size = new Size(132, 79);
            salesOfProduct.TabIndex = 8;
            // 
            // SaleInProduct
            // 
            SaleInProduct.AutoSize = true;
            SaleInProduct.Location = new Point(523, 121);
            SaleInProduct.Name = "SaleInProduct";
            SaleInProduct.Size = new Size(86, 15);
            SaleInProduct.TabIndex = 9;
            SaleInProduct.Text = "Sale In Product";
            SaleInProduct.Click += SaleInProduct_Click;
            // 
            // sendIt
            // 
            sendIt.Location = new Point(299, 194);
            sendIt.Margin = new Padding(3, 2, 3, 2);
            sendIt.Name = "sendIt";
            sendIt.Size = new Size(82, 22);
            sendIt.TabIndex = 10;
            sendIt.Text = "send it";
            sendIt.UseVisualStyleBackColor = true;
            sendIt.Click += sendIt_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(42, 40);
            id.Name = "id";
            id.Size = new Size(17, 15);
            id.TabIndex = 11;
            id.Text = "id";
            // 
            // insertId
            // 
            insertId.Location = new Point(5, 67);
            insertId.Margin = new Padding(3, 2, 3, 2);
            insertId.Name = "insertId";
            insertId.Size = new Size(110, 23);
            insertId.TabIndex = 12;
            // 
            // CreateOrUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateOrUpdateProduct";
            Text = "Create or update product";
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