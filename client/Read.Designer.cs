namespace client
{
    partial class Read
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
            id = new Label();
            enterId = new TextBox();
            find = new Button();
            SuspendLayout();
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(590, 73);
            id.Name = "id";
            id.Size = new Size(22, 20);
            id.TabIndex = 0;
            id.Text = "id";
            // 
            // enterId
            // 
            enterId.Location = new Point(552, 112);
            enterId.Name = "enterId";
            enterId.Size = new Size(125, 27);
            enterId.TabIndex = 1;
            // 
            // find
            // 
            find.Location = new Point(565, 167);
            find.Name = "find";
            find.Size = new Size(94, 29);
            find.TabIndex = 2;
            find.Text = "find";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // Read
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(find);
            Controls.Add(enterId);
            Controls.Add(id);
            Name = "Read";
            Text = "Read";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label id;
        private TextBox enterId;
        private Button find;
    }
}