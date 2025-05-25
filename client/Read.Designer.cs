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
            insert_me = new Label();
            SuspendLayout();
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            id.Location = new Point(411, 89);
            id.Name = "id";
            id.Size = new Size(36, 32);
            id.TabIndex = 0;
            id.Text = "id";
            // 
            // enterId
            // 
            enterId.Location = new Point(336, 139);
            enterId.Name = "enterId";
            enterId.Size = new Size(171, 27);
            enterId.TabIndex = 1;
            enterId.TextChanged += enterId_TextChanged;
            // 
            // find
            // 
            find.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            find.Location = new Point(346, 233);
            find.Name = "find";
            find.Size = new Size(140, 56);
            find.TabIndex = 2;
            find.Text = "find";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // insert_me
            // 
            insert_me.AutoSize = true;
            insert_me.Location = new Point(336, 341);
            insert_me.Name = "insert_me";
            insert_me.Size = new Size(0, 20);
            insert_me.TabIndex = 3;
            // 
            // Read
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(insert_me);
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
        private Label insert_me;
    }
}