namespace client
{
    partial class delete
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
            id = new Button();
            enterId = new TextBox();
            del = new Button();
            SuspendLayout();
            // 
            // id
            // 
            id.Location = new Point(579, 87);
            id.Name = "id";
            id.Size = new Size(94, 29);
            id.TabIndex = 0;
            id.Text = "id";
            id.UseVisualStyleBackColor = true;
            // 
            // enterId
            // 
            enterId.Location = new Point(564, 142);
            enterId.Name = "enterId";
            enterId.Size = new Size(125, 27);
            enterId.TabIndex = 1;
            // 
            // del
            // 
            del.Location = new Point(579, 210);
            del.Name = "del";
            del.Size = new Size(94, 29);
            del.TabIndex = 2;
            del.Text = "delete";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(del);
            Controls.Add(enterId);
            Controls.Add(id);
            Name = "delete";
            Text = "delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button id;
        private TextBox enterId;
        private Button del;
    }
}