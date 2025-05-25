namespace client
{
    partial class CreateOrUpdateCustomer
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
            customerName = new Label();
            fillCustomerName = new TextBox();
            fillCustomerId = new TextBox();
            customerId = new Label();
            fillAddressCustomer = new TextBox();
            customerAddress = new Label();
            customerPhone = new Label();
            sendItCustomer = new Button();
            fillPhoneCustomer = new TextBox();
            SuspendLayout();
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            customerName.Location = new Point(515, 54);
            customerName.Name = "customerName";
            customerName.Size = new Size(70, 30);
            customerName.TabIndex = 0;
            customerName.Text = "name";
            // 
            // fillCustomerName
            // 
            fillCustomerName.Location = new Point(481, 92);
            fillCustomerName.Name = "fillCustomerName";
            fillCustomerName.Size = new Size(125, 27);
            fillCustomerName.TabIndex = 1;
            fillCustomerName.TextChanged += textBox1_TextChanged;
            // 
            // fillCustomerId
            // 
            fillCustomerId.Location = new Point(639, 92);
            fillCustomerId.Name = "fillCustomerId";
            fillCustomerId.Size = new Size(125, 27);
            fillCustomerId.TabIndex = 3;
            // 
            // customerId
            // 
            customerId.AutoSize = true;
            customerId.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            customerId.Location = new Point(688, 54);
            customerId.Name = "customerId";
            customerId.Size = new Size(33, 30);
            customerId.TabIndex = 2;
            customerId.Text = "id";
            customerId.Click += customerId_Click;
            // 
            // fillAddressCustomer
            // 
            fillAddressCustomer.Location = new Point(302, 92);
            fillAddressCustomer.Name = "fillAddressCustomer";
            fillAddressCustomer.Size = new Size(125, 27);
            fillAddressCustomer.TabIndex = 5;
            // 
            // customerAddress
            // 
            customerAddress.AutoSize = true;
            customerAddress.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            customerAddress.Location = new Point(328, 55);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(94, 30);
            customerAddress.TabIndex = 4;
            customerAddress.Text = "address";
            // 
            // customerPhone
            // 
            customerPhone.AutoSize = true;
            customerPhone.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            customerPhone.Location = new Point(131, 55);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(78, 30);
            customerPhone.TabIndex = 6;
            customerPhone.Text = "phone";
            // 
            // sendItCustomer
            // 
            sendItCustomer.BackColor = SystemColors.ButtonHighlight;
            sendItCustomer.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            sendItCustomer.ForeColor = Color.Coral;
            sendItCustomer.Location = new Point(349, 225);
            sendItCustomer.Name = "sendItCustomer";
            sendItCustomer.Size = new Size(129, 75);
            sendItCustomer.TabIndex = 11;
            sendItCustomer.Text = "send it";
            sendItCustomer.UseVisualStyleBackColor = false;
            sendItCustomer.Click += sendItCustomer_Click;
            // 
            // fillPhoneCustomer
            // 
            fillPhoneCustomer.Location = new Point(107, 92);
            fillPhoneCustomer.Name = "fillPhoneCustomer";
            fillPhoneCustomer.Size = new Size(125, 27);
            fillPhoneCustomer.TabIndex = 12;
            // 
            // CreateOrUpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(fillPhoneCustomer);
            Controls.Add(sendItCustomer);
            Controls.Add(customerPhone);
            Controls.Add(fillAddressCustomer);
            Controls.Add(customerAddress);
            Controls.Add(fillCustomerId);
            Controls.Add(customerId);
            Controls.Add(fillCustomerName);
            Controls.Add(customerName);
            ForeColor = Color.Coral;
            Name = "CreateOrUpdateCustomer";
            Text = "create or update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerName;
        private TextBox fillCustomerName;
        private TextBox fillCustomerId;
        private Label customerId;
        private TextBox fillAddressCustomer;
        private Label customerAddress;
        private Label customerPhone;
        private Button sendItCustomer;
        private TextBox fillPhoneCustomer;
    }
}