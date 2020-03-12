namespace WindowsFormsApp1.UserControls
{
    partial class SellUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pesoTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.exchangeRateTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dolarTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.printChkBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.saveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.sellRecorDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellRecorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Exchange Rate";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Amount in Pesos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Amount in Dollars";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(401, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
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
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Print Transaction Recipt";
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
            this.pesoTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pesoTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pesoTxtBox.LineThickness = 10;
            this.pesoTxtBox.Location = new System.Drawing.Point(623, 68);
            this.pesoTxtBox.Margin = new System.Windows.Forms.Padding(6, 5, 2, 5);
            this.pesoTxtBox.Name = "pesoTxtBox";
            this.pesoTxtBox.Size = new System.Drawing.Size(350, 100);
            this.pesoTxtBox.TabIndex = 10;
            this.pesoTxtBox.Text = "250";
            this.pesoTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.exchangeRateTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exchangeRateTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exchangeRateTxtBox.LineThickness = 10;
            this.exchangeRateTxtBox.Location = new System.Drawing.Point(401, 68);
            this.exchangeRateTxtBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.exchangeRateTxtBox.Name = "exchangeRateTxtBox";
            this.exchangeRateTxtBox.Size = new System.Drawing.Size(201, 100);
            this.exchangeRateTxtBox.TabIndex = 1;
            this.exchangeRateTxtBox.Text = "2.5";
            this.exchangeRateTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exchangeRateTxtBox.OnValueChanged += new System.EventHandler(this.exchangeRateTxtBox_OnValueChanged);
            this.exchangeRateTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exchangeRateTxtBox_KeyDown);
            this.exchangeRateTxtBox.Leave += new System.EventHandler(this.exchangeRateTxtBox_Leave);
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
            this.dolarTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dolarTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.dolarTxtBox.Leave += new System.EventHandler(this.dolarTxtBox_Leave);
            // 
            // printChkBox
            // 
            this.printChkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.printChkBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.printChkBox.Checked = true;
            this.printChkBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.printChkBox.ForeColor = System.Drawing.Color.White;
            this.printChkBox.Location = new System.Drawing.Point(32, 206);
            this.printChkBox.Name = "printChkBox";
            this.printChkBox.Size = new System.Drawing.Size(20, 20);
            this.printChkBox.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.ActiveBorderThickness = 1;
            this.saveBtn.ActiveCornerRadius = 20;
            this.saveBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.saveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.saveBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.ButtonText = "Do Transaction";
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.saveBtn.IdleBorderThickness = 1;
            this.saveBtn.IdleCornerRadius = 20;
            this.saveBtn.IdleFillColor = System.Drawing.Color.White;
            this.saveBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.saveBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.saveBtn.Location = new System.Drawing.Point(32, 230);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(938, 59);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Print Transaction Recipt";
            // 
            // sellRecorDGV
            // 
            this.sellRecorDGV.AllowUserToAddRows = false;
            this.sellRecorDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sellRecorDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.sellRecorDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellRecorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellRecorDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.sellRecorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellRecorDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellRecorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.sellRecorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellRecorDGV.DoubleBuffered = true;
            this.sellRecorDGV.EnableHeadersVisualStyles = false;
            this.sellRecorDGV.GridColor = System.Drawing.Color.WhiteSmoke;
            this.sellRecorDGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sellRecorDGV.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellRecorDGV.Location = new System.Drawing.Point(35, 318);
            this.sellRecorDGV.Name = "sellRecorDGV";
            this.sellRecorDGV.ReadOnly = true;
            this.sellRecorDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sellRecorDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.sellRecorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellRecorDGV.Size = new System.Drawing.Size(938, 172);
            this.sellRecorDGV.TabIndex = 27;
            // 
            // SellUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sellRecorDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.printChkBox);
            this.Controls.Add(this.dolarTxtBox);
            this.Controls.Add(this.exchangeRateTxtBox);
            this.Controls.Add(this.pesoTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SellUC";
            this.Size = new System.Drawing.Size(1003, 516);
            this.Load += new System.EventHandler(this.SellUC_Load);
            this.VisibleChanged += new System.EventHandler(this.SellUC_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellRecorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pesoTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox exchangeRateTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dolarTxtBox;
        private Bunifu.Framework.UI.BunifuCheckbox printChkBox;
        private Bunifu.Framework.UI.BunifuThinButton2 saveBtn;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid sellRecorDGV;
    }
}
