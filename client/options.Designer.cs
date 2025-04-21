namespace client
{
    partial class options
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
            create = new Button();
            update = new Button();
            readAll = new Button();
            read = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // create
            // 
            create.Location = new Point(605, 138);
            create.Name = "create";
            create.Size = new Size(94, 29);
            create.TabIndex = 0;
            create.Text = "create";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // update
            // 
            update.Location = new Point(386, 192);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 1;
            update.Text = "update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // readAll
            // 
            readAll.Location = new Point(422, 92);
            readAll.Name = "readAll";
            readAll.Size = new Size(94, 29);
            readAll.TabIndex = 2;
            readAll.Text = "readAll";
            readAll.UseVisualStyleBackColor = true;
            readAll.Click += readAll_Click;
            // 
            // read
            // 
            read.Location = new Point(577, 229);
            read.Name = "read";
            read.Size = new Size(94, 29);
            read.TabIndex = 3;
            read.Text = "read";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // delete
            // 
            delete.Location = new Point(523, 327);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 4;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // options
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(read);
            Controls.Add(readAll);
            Controls.Add(update);
            Controls.Add(create);
            Name = "options";
            Text = "options";
            ResumeLayout(false);
        }

        #endregion

        private Button create;
        private Button update;
        private Button readAll;
        private Button read;
        private Button delete;
    }
}