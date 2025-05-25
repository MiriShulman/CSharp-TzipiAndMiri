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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            buttonSaleMan = new Button();
            buttonAdmin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSaleMan
            // 
            buttonSaleMan.BackColor = Color.LightCyan;
            buttonSaleMan.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            buttonSaleMan.ForeColor = Color.ForestGreen;
            buttonSaleMan.Location = new Point(220, 182);
            buttonSaleMan.Name = "buttonSaleMan";
            buttonSaleMan.Size = new Size(173, 72);
            buttonSaleMan.TabIndex = 0;
            buttonSaleMan.Text = "קופאי";
            buttonSaleMan.UseVisualStyleBackColor = false;
            buttonSaleMan.Click += buttonSaleMan_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.LightCyan;
            buttonAdmin.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            buttonAdmin.ForeColor = Color.ForestGreen;
            buttonAdmin.Location = new Point(484, 182);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(165, 72);
            buttonAdmin.TabIndex = 1;
            buttonAdmin.Text = "מנהל";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(333, 58);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 68);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(882, 506);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAdmin);
            Controls.Add(buttonSaleMan);
            Name = "home";
            Text = "home";
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSaleMan;
        private Button buttonAdmin;
        private PictureBox pictureBox1;
    }
}