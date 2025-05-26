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
            fillIdSale = new TextBox();
            saleId = new Label();
            fillSaleCode = new TextBox();
            saleCode = new Label();
            minimumAmountSale = new Label();
            fillMinimumAmountSale = new NumericUpDown();
            fillSumSale = new NumericUpDown();
            sumSale = new Label();
            label1 = new Label();
            isNeedClub = new RadioButton();
            fillBeginSale = new DateTimePicker();
            fillEndSale = new DateTimePicker();
            beginSale = new Label();
            endSale = new Label();
            sendItSale = new Button();
            ((System.ComponentModel.ISupportInitialize)fillMinimumAmountSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fillSumSale).BeginInit();
            SuspendLayout();
            // 
            // fillIdSale
            // 
            fillIdSale.Location = new Point(494, 96);
            fillIdSale.Name = "fillIdSale";
            fillIdSale.Size = new Size(125, 27);
            fillIdSale.TabIndex = 14;
            // 
            // saleId
            // 
            saleId.AutoSize = true;
            saleId.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            saleId.ForeColor = Color.IndianRed;
            saleId.Location = new Point(536, 60);
            saleId.Name = "saleId";
            saleId.Size = new Size(29, 25);
            saleId.TabIndex = 13;
            saleId.Text = "id";
            // 
            // fillSaleCode
            // 
            fillSaleCode.Location = new Point(649, 96);
            fillSaleCode.Name = "fillSaleCode";
            fillSaleCode.Size = new Size(125, 27);
            fillSaleCode.TabIndex = 16;
            // 
            // saleCode
            // 
            saleCode.AutoSize = true;
            saleCode.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            saleCode.ForeColor = Color.IndianRed;
            saleCode.Location = new Point(691, 60);
            saleCode.Name = "saleCode";
            saleCode.Size = new Size(55, 25);
            saleCode.TabIndex = 15;
            saleCode.Text = "code";
            // 
            // minimumAmountSale
            // 
            minimumAmountSale.AutoSize = true;
            minimumAmountSale.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            minimumAmountSale.ForeColor = Color.IndianRed;
            minimumAmountSale.Location = new Point(309, 60);
            minimumAmountSale.Name = "minimumAmountSale";
            minimumAmountSale.Size = new Size(172, 25);
            minimumAmountSale.TabIndex = 17;
            minimumAmountSale.Text = "minimum amount";
            // 
            // fillMinimumAmountSale
            // 
            fillMinimumAmountSale.Location = new Point(321, 96);
            fillMinimumAmountSale.Name = "fillMinimumAmountSale";
            fillMinimumAmountSale.Size = new Size(150, 27);
            fillMinimumAmountSale.TabIndex = 18;
            // 
            // fillSumSale
            // 
            fillSumSale.Location = new Point(139, 96);
            fillSumSale.Name = "fillSumSale";
            fillSumSale.Size = new Size(150, 27);
            fillSumSale.TabIndex = 20;
            // 
            // sumSale
            // 
            sumSale.AutoSize = true;
            sumSale.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            sumSale.ForeColor = Color.IndianRed;
            sumSale.Location = new Point(190, 60);
            sumSale.Name = "sumSale";
            sumSale.Size = new Size(49, 25);
            sumSale.TabIndex = 19;
            sumSale.Text = "sum";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(670, 156);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 21;
            // 
            // isNeedClub
            // 
            isNeedClub.AutoSize = true;
            isNeedClub.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            isNeedClub.ForeColor = Color.IndianRed;
            isNeedClub.Location = new Point(601, 189);
            isNeedClub.Name = "isNeedClub";
            isNeedClub.Size = new Size(146, 29);
            isNeedClub.TabIndex = 22;
            isNeedClub.TabStop = true;
            isNeedClub.Text = "is need club?";
            isNeedClub.UseVisualStyleBackColor = true;
            isNeedClub.CheckedChanged += isNeedClub_CheckedChanged;
            // 
            // fillBeginSale
            // 
            fillBeginSale.Location = new Point(334, 233);
            fillBeginSale.Name = "fillBeginSale";
            fillBeginSale.Size = new Size(250, 27);
            fillBeginSale.TabIndex = 23;
            // 
            // fillEndSale
            // 
            fillEndSale.Location = new Point(39, 233);
            fillEndSale.Name = "fillEndSale";
            fillEndSale.Size = new Size(250, 27);
            fillEndSale.TabIndex = 24;
            // 
            // beginSale
            // 
            beginSale.AutoSize = true;
            beginSale.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            beginSale.ForeColor = Color.IndianRed;
            beginSale.Location = new Point(415, 192);
            beginSale.Name = "beginSale";
            beginSale.Size = new Size(101, 25);
            beginSale.TabIndex = 25;
            beginSale.Text = "begin sale";
            // 
            // endSale
            // 
            endSale.AutoSize = true;
            endSale.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            endSale.ForeColor = Color.IndianRed;
            endSale.Location = new Point(119, 195);
            endSale.Name = "endSale";
            endSale.Size = new Size(84, 25);
            endSale.TabIndex = 26;
            endSale.Text = "end sale";
            // 
            // sendItSale
            // 
            sendItSale.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold);
            sendItSale.ForeColor = Color.DarkRed;
            sendItSale.Location = new Point(321, 307);
            sendItSale.Name = "sendItSale";
            sendItSale.Size = new Size(139, 56);
            sendItSale.TabIndex = 27;
            sendItSale.Text = "send it";
            sendItSale.UseVisualStyleBackColor = true;
            sendItSale.Click += sendItSale_Click;
            // 
            // CreateOrUpdateSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 451);
            Controls.Add(sendItSale);
            Controls.Add(endSale);
            Controls.Add(beginSale);
            Controls.Add(fillEndSale);
            Controls.Add(fillBeginSale);
            Controls.Add(isNeedClub);
            Controls.Add(label1);
            Controls.Add(fillSumSale);
            Controls.Add(sumSale);
            Controls.Add(fillMinimumAmountSale);
            Controls.Add(minimumAmountSale);
            Controls.Add(fillSaleCode);
            Controls.Add(saleCode);
            Controls.Add(fillIdSale);
            Controls.Add(saleId);
            Name = "CreateOrUpdateSale";
            Text = "Create or update sale";
            ((System.ComponentModel.ISupportInitialize)fillMinimumAmountSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)fillSumSale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fillIdSale;
        private Label saleId;
        private TextBox fillSaleCode;
        private Label saleCode;
        private Label minimumAmountSale;
        private NumericUpDown fillMinimumAmountSale;
        private NumericUpDown fillSumSale;
        private Label sumSale;
        private Label label1;
        private RadioButton isNeedClub;
        private DateTimePicker fillBeginSale;
        private DateTimePicker fillEndSale;
        private Label beginSale;
        private Label endSale;
        private Button sendItSale;
    }
}