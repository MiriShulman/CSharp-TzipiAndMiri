namespace client
{
    partial class home
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
            buttonSaleMan = new Button();
            buttonAdmin = new Button();
            SuspendLayout();
            // 
            // buttonSaleMan
            // 
            buttonSaleMan.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonSaleMan.Location = new Point(233, 191);
            buttonSaleMan.Name = "buttonSaleMan";
            buttonSaleMan.Size = new Size(136, 82);
            buttonSaleMan.TabIndex = 0;
            buttonSaleMan.Text = "קופאי";
            buttonSaleMan.UseVisualStyleBackColor = true;
            buttonSaleMan.Click += buttonSaleMan_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonAdmin.Location = new Point(497, 191);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(128, 82);
            buttonAdmin.TabIndex = 1;
            buttonAdmin.Text = "מנהל";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(882, 506);
            Controls.Add(buttonAdmin);
            Controls.Add(buttonSaleMan);
            Name = "home";
            Text = "home";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSaleMan;
        private Button buttonAdmin;
    }
}