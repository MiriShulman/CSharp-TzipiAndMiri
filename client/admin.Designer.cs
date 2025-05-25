namespace client
{
    partial class admin
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
            customers = new Button();
            sales = new Button();
            products = new Button();
            SuspendLayout();
            // 
            // customers
            // 
            customers.BackColor = Color.LightPink;
            customers.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            customers.Location = new Point(596, 193);
            customers.Name = "customers";
            customers.RightToLeft = RightToLeft.Yes;
            customers.Size = new Size(222, 80);
            customers.TabIndex = 0;
            customers.Text = "customers";
            customers.UseVisualStyleBackColor = false;
            customers.Click += customers_Click;
            // 
            // sales
            // 
            sales.BackColor = Color.LightPink;
            sales.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sales.Location = new Point(357, 193);
            sales.Name = "sales";
            sales.Size = new Size(222, 80);
            sales.TabIndex = 1;
            sales.Text = "sales";
            sales.UseVisualStyleBackColor = false;
            sales.Click += sales_Click;
            // 
            // products
            // 
            products.BackColor = Color.LightPink;
            products.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            products.Location = new Point(118, 193);
            products.Name = "products";
            products.Size = new Size(222, 80);
            products.TabIndex = 2;
            products.Text = "products";
            products.UseVisualStyleBackColor = false;
            products.Click += products_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(905, 509);
            Controls.Add(products);
            Controls.Add(sales);
            Controls.Add(customers);
            Name = "admin";
            Text = "enter";
            ResumeLayout(false);
        }

        #endregion

        private Button customers;
        private Button sales;
        private Button products;
    }
}