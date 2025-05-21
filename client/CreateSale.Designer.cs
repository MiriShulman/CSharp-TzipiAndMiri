namespace client
{
    partial class CreateOrUpdateSale
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
            code = new Label();
            SuspendLayout();
            // 
            // code
            // 
            code.AutoSize = true;
            code.Location = new Point(582, 43);
            code.Name = "code";
            code.Size = new Size(33, 15);
            code.TabIndex = 0;
            code.Text = "code";
            // 
            // CreateOrUpdateSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(code);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateOrUpdateSale";
            Text = "Create or update sale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label code;
    }
}