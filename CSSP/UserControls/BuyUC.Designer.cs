namespace WindowsFormsApp1.UserControls
{
    partial class BuyUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.printChkBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.dolarTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.exchangeRateTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pesoTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buyRecordDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyRecordDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount in Dollars";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount in Pesos";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exchange Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Print Transaction Recipt";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(401, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(623, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.ActiveBorderThickness = 1;
            this.saveBtn.ActiveCornerRadius = 20;
            this.saveBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.saveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.saveBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.ButtonText = "Do Transaction";
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.saveBtn.IdleBorderThickness = 1;
            this.saveBtn.IdleCornerRadius = 20;
            this.saveBtn.IdleFillColor = System.Drawing.Color.White;
            this.saveBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.saveBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.saveBtn.Location = new System.Drawing.Point(32, 239);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(938, 59);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // printChkBox
            // 
            this.printChkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.printChkBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.printChkBox.Checked = true;
            this.printChkBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.printChkBox.ForeColor = System.Drawing.Color.White;
            this.printChkBox.Location = new System.Drawing.Point(32, 206);
            this.printChkBox.Name = "printChkBox";
            this.printChkBox.Size = new System.Drawing.Size(20, 20);
            this.printChkBox.TabIndex = 3;
            // 
            // dolarTxtBox
            // 
            this.dolarTxtBox.BackColor = System.Drawing.Color.White;
            this.dolarTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dolarTxtBox.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolarTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dolarTxtBox.HintForeColor = System.Drawing.Color.Empty;
            this.dolarTxtBox.HintText = "";
            this.dolarTxtBox.isPassword = false;
            this.dolarTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dolarTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.dolarTxtBox.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.dolarTxtBox.LineThickness = 10;
            this.dolarTxtBox.Location = new System.Drawing.Point(35, 68);
            this.dolarTxtBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dolarTxtBox.Name = "dolarTxtBox";
            this.dolarTxtBox.Size = new System.Drawing.Size(350, 100);
            this.dolarTxtBox.TabIndex = 0;
            this.dolarTxtBox.Text = "100";
            this.dolarTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dolarTxtBox.OnValueChanged += new System.EventHandler(this.dolarTxtBox_OnValueChanged);
            this.dolarTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dolarTxtBox_KeyDown);
            this.dolarTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox2_KeyPress);
            this.dolarTxtBox.Leave += new System.EventHandler(this.dolarTxtBox_Leave);
            // 
            // exchangeRateTxtBox
            // 
            this.exchangeRateTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exchangeRateTxtBox.BackColor = System.Drawing.Color.White;
            this.exchangeRateTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exchangeRateTxtBox.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.exchangeRateTxtBox.HintForeColor = System.Drawing.Color.Empty;
            this.exchangeRateTxtBox.HintText = "";
            this.exchangeRateTxtBox.isPassword = false;
            this.exchangeRateTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exchangeRateTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.exchangeRateTxtBox.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.exchangeRateTxtBox.LineThickness = 10;
            this.exchangeRateTxtBox.Location = new System.Drawing.Point(401, 68);
            this.exchangeRateTxtBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.exchangeRateTxtBox.Name = "exchangeRateTxtBox";
            this.exchangeRateTxtBox.Size = new System.Drawing.Size(201, 100);
            this.exchangeRateTxtBox.TabIndex = 1;
            this.exchangeRateTxtBox.Text = "2.5";
            this.exchangeRateTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exchangeRateTxtBox.OnValueChanged += new System.EventHandler(this.exchangeRateTxtBox_OnValueChanged);
            this.exchangeRateTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exchangeTxtBox_KeyDown);
            this.exchangeRateTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox2_KeyPress);
            this.exchangeRateTxtBox.Leave += new System.EventHandler(this.exchangeRateTxtBox_Leave);
            // 
            // pesoTxtBox
            // 
            this.pesoTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pesoTxtBox.BackColor = System.Drawing.Color.White;
            this.pesoTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pesoTxtBox.Enabled = false;
            this.pesoTxtBox.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.pesoTxtBox.HintForeColor = System.Drawing.Color.Empty;
            this.pesoTxtBox.HintText = "";
            this.pesoTxtBox.isPassword = false;
            this.pesoTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pesoTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.pesoTxtBox.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.pesoTxtBox.LineThickness = 10;
            this.pesoTxtBox.Location = new System.Drawing.Point(623, 68);
            this.pesoTxtBox.Margin = new System.Windows.Forms.Padding(6, 5, 2, 5);
            this.pesoTxtBox.Name = "pesoTxtBox";
            this.pesoTxtBox.Size = new System.Drawing.Size(350, 100);
            this.pesoTxtBox.TabIndex = 2;
            this.pesoTxtBox.Text = "250";
            this.pesoTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buyRecordDGV
            // 
            this.buyRecordDGV.AllowUserToAddRows = false;
            this.buyRecordDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buyRecordDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.buyRecordDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyRecordDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buyRecordDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.buyRecordDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buyRecordDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buyRecordDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.buyRecordDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyRecordDGV.DoubleBuffered = true;
            this.buyRecordDGV.EnableHeadersVisualStyles = false;
            this.buyRecordDGV.GridColor = System.Drawing.Color.WhiteSmoke;
            this.buyRecordDGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.buyRecordDGV.HeaderForeColor = System.Drawing.Color.White;
            this.buyRecordDGV.Location = new System.Drawing.Point(35, 327);
            this.buyRecordDGV.Name = "buyRecordDGV";
            this.buyRecordDGV.ReadOnly = true;
            this.buyRecordDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.buyRecordDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buyRecordDGV.Size = new System.Drawing.Size(938, 172);
            this.buyRecordDGV.TabIndex = 13;
            // 
            // BuyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buyRecordDGV);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.printChkBox);
            this.Controls.Add(this.dolarTxtBox);
            this.Controls.Add(this.exchangeRateTxtBox);
            this.Controls.Add(this.pesoTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.Name = "BuyUC";
            this.Size = new System.Drawing.Size(1003, 516);
            this.Load += new System.EventHandler(this.BuyUC_Load);
            this.VisibleChanged += new System.EventHandler(this.BuyUC_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyRecordDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 saveBtn;
        private Bunifu.Framework.UI.BunifuCheckbox printChkBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dolarTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox exchangeRateTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pesoTxtBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid buyRecordDGV;
    }
}
