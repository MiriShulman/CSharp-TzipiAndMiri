using System.Collections.Generic;

namespace client
{
    partial class ReadAll
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
            TList = new Label();
            list = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)list).BeginInit();
            SuspendLayout();
            // 
            // TList
            // 
            TList.AutoSize = true;
            TList.Font = new Font("Stencil", 15F, FontStyle.Bold);
            TList.ForeColor = Color.DarkGreen;
            TList.Location = new Point(274, 31);
            TList.Name = "TList";
            TList.Size = new Size(175, 24);
            TList.TabIndex = 0;
            TList.Text = "רשימת המוצרים בחנות";
            // 
            // list
            // 
            list.BackgroundColor = Color.White;
            list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list.Location = new Point(128, 80);
            list.Margin = new Padding(3, 2, 3, 2);
            list.Name = "list";
            list.RowHeadersWidth = 51;
            list.RowTemplate.Height = 29;
            list.Size = new Size(456, 213);
            list.TabIndex = 3;
            list.CellContentClick += productsListView_CellContentClick;
            // 
            // ReadAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(717, 354);
            Controls.Add(list);
            Controls.Add(TList);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReadAll";
            Text = "ReadAll";
            ((System.ComponentModel.ISupportInitialize)list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TList;
        private DataGridView list;
    }
}