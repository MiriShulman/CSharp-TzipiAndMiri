namespace client
{
    partial class enter
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
            order = new Button();
            SuspendLayout();
            // 
            // customers
            // 
            customers.Location = new Point(550, 127);
            customers.Name = "customers";
            customers.RightToLeft = RightToLeft.Yes;
            customers.Size = new Size(94, 29);
            customers.TabIndex = 0;
            customers.Text = "customers";
            customers.UseVisualStyleBackColor = true;
            // 
            // sales
            // 
            sales.Location = new Point(384, 127);
            sales.Name = "sales";
            sales.Size = new Size(94, 29);
            sales.TabIndex = 1;
            sales.Text = "sales";
            sales.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            products.Location = new Point(243, 127);
            products.Name = "products";
            products.Size = new Size(94, 29);
            products.TabIndex = 2;
            products.Text = "products";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // order
            // 
            order.Location = new Point(80, 127);
            order.Name = "order";
            order.Size = new Size(94, 29);
            order.TabIndex = 3;
            order.Text = "order";
            order.UseVisualStyleBackColor = true;
            // 
            // enter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(order);
            Controls.Add(products);
            Controls.Add(sales);
            Controls.Add(customers);
            Name = "enter";
            Text = "enter";
            ResumeLayout(false);
        }

        #endregion

        private Button customers;
        private Button sales;
        private Button products;
        private Button order;
    }
}