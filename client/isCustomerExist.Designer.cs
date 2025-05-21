namespace UI
{
    partial class isCustomerExist
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
            inpuId = new TextBox();
            labelId = new Label();
            isExist = new Label();
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
            // inpuId
            // 
            inpuId.Location = new Point(338, 192);
            inpuId.Name = "inpuId";
            inpuId.Size = new Size(100, 23);
            inpuId.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.BackColor = Color.LavenderBlush;
            labelId.Font = new Font("Segoe UI", 13F);
            labelId.Location = new Point(238, 114);
            labelId.Name = "labelId";
            labelId.Size = new Size(335, 25);
            labelId.TabIndex = 2;
            labelId.Text = "של משתמש כדי לוודא שהוא קיים ID הכנס";
            // 
            // isExist
            // 
            isExist.AutoSize = true;
            isExist.Location = new Point(370, 355);
            isExist.Name = "isExist";
            isExist.Size = new Size(0, 15);
            isExist.TabIndex = 3;
            // 
            // isCustomerExist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(isExist);
            Controls.Add(labelId);
            Controls.Add(inpuId);
            Controls.Add(submitId);
            Name = "isCustomerExist";
            Text = "isCustomerExist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitId;
        private TextBox inpuId;
        private Label labelId;
        private Label isExist;
    }
}