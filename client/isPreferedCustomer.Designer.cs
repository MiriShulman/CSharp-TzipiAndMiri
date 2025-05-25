namespace client
{
    partial class isPreferedCustomer
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
            submitId = new Button();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // submitId
            // 
            submitId.BackColor = Color.Crimson;
            submitId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            submitId.ForeColor = SystemColors.ButtonFace;
            submitId.Location = new Point(358, 266);
            submitId.Name = "submitId";
            submitId.Size = new Size(67, 28);
            submitId.TabIndex = 0;
            submitId.Text = "שלח";
            submitId.UseVisualStyleBackColor = false;
            submitId.Click += submitId_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            radioButton1.ForeColor = Color.IndianRed;
            radioButton1.Location = new Point(288, 138);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(201, 32);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "do you have club?";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // isPreferedCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton1);
            Controls.Add(submitId);
            Name = "isPreferedCustomer";
            Text = "isCustomerExist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitId;
        private RadioButton radioButton1;
    }
}