namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.reportsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exchangeRateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sellBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buyBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BelowLogoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subHeaderPanel = new System.Windows.Forms.Panel();
            this.headingLable = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buyUC2 = new WindowsFormsApp1.UserControls.BuyUC();
            this.excahngeRatesUC1 = new WindowsFormsApp1.UserControls.ExcahngeRatesUC();
            this.reportsUC2 = new WindowsFormsApp1.UserControls.ReportsUC();
            this.sellUC2 = new WindowsFormsApp1.UserControls.SellUC();
            this.SidebarPanel.SuspendLayout();
            this.BelowLogoPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.subHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.SidebarPanel.Controls.Add(this.reportsBtn);
            this.SidebarPanel.Controls.Add(this.exchangeRateBtn);
            this.SidebarPanel.Controls.Add(this.sellBtn);
            this.SidebarPanel.Controls.Add(this.buyBtn);
            this.SidebarPanel.Controls.Add(this.BelowLogoPanel);
            this.SidebarPanel.Controls.Add(this.logoPanel);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(194, 706);
            this.SidebarPanel.TabIndex = 0;
            // 
            // reportsBtn
            // 
            this.reportsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.reportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.reportsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportsBtn.BorderRadius = 0;
            this.reportsBtn.ButtonText = "   Reports";
            this.reportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.reportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBtn.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.reportsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("reportsBtn.Iconimage")));
            this.reportsBtn.Iconimage_right = null;
            this.reportsBtn.Iconimage_right_Selected = null;
            this.reportsBtn.Iconimage_Selected = null;
            this.reportsBtn.IconMarginLeft = 0;
            this.reportsBtn.IconMarginRight = 0;
            this.reportsBtn.IconRightVisible = true;
            this.reportsBtn.IconRightZoom = 0D;
            this.reportsBtn.IconVisible = true;
            this.reportsBtn.IconZoom = 50D;
            this.reportsBtn.IsTab = false;
            this.reportsBtn.Location = new System.Drawing.Point(0, 301);
            this.reportsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.reportsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.reportsBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.reportsBtn.selected = false;
            this.reportsBtn.Size = new System.Drawing.Size(194, 56);
            this.reportsBtn.TabIndex = 5;
            this.reportsBtn.Text = "   Reports";
            this.reportsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // exchangeRateBtn
            // 
            this.exchangeRateBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.exchangeRateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.exchangeRateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exchangeRateBtn.BorderRadius = 0;
            this.exchangeRateBtn.ButtonText = "   Excahange Rates";
            this.exchangeRateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exchangeRateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.exchangeRateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exchangeRateBtn.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.exchangeRateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("exchangeRateBtn.Iconimage")));
            this.exchangeRateBtn.Iconimage_right = null;
            this.exchangeRateBtn.Iconimage_right_Selected = null;
            this.exchangeRateBtn.Iconimage_Selected = null;
            this.exchangeRateBtn.IconMarginLeft = 0;
            this.exchangeRateBtn.IconMarginRight = 0;
            this.exchangeRateBtn.IconRightVisible = true;
            this.exchangeRateBtn.IconRightZoom = 0D;
            this.exchangeRateBtn.IconVisible = true;
            this.exchangeRateBtn.IconZoom = 50D;
            this.exchangeRateBtn.IsTab = false;
            this.exchangeRateBtn.Location = new System.Drawing.Point(0, 245);
            this.exchangeRateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exchangeRateBtn.Name = "exchangeRateBtn";
            this.exchangeRateBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.exchangeRateBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.exchangeRateBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.exchangeRateBtn.selected = false;
            this.exchangeRateBtn.Size = new System.Drawing.Size(194, 56);
            this.exchangeRateBtn.TabIndex = 4;
            this.exchangeRateBtn.Text = "   Excahange Rates";
            this.exchangeRateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exchangeRateBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exchangeRateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateBtn.Click += new System.EventHandler(this.exchangeRateBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.sellBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.sellBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sellBtn.BorderRadius = 0;
            this.sellBtn.ButtonText = "   Sell";
            this.sellBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sellBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sellBtn.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sellBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("sellBtn.Iconimage")));
            this.sellBtn.Iconimage_right = null;
            this.sellBtn.Iconimage_right_Selected = null;
            this.sellBtn.Iconimage_Selected = null;
            this.sellBtn.IconMarginLeft = 0;
            this.sellBtn.IconMarginRight = 0;
            this.sellBtn.IconRightVisible = true;
            this.sellBtn.IconRightZoom = 0D;
            this.sellBtn.IconVisible = true;
            this.sellBtn.IconZoom = 50D;
            this.sellBtn.IsTab = false;
            this.sellBtn.Location = new System.Drawing.Point(0, 189);
            this.sellBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.sellBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.sellBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.sellBtn.selected = false;
            this.sellBtn.Size = new System.Drawing.Size(194, 56);
            this.sellBtn.TabIndex = 3;
            this.sellBtn.Text = "   Sell";
            this.sellBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.buyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.buyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buyBtn.BorderRadius = 0;
            this.buyBtn.ButtonText = "   Buy";
            this.buyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyBtn.DisabledColor = System.Drawing.Color.Gray;
            this.buyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buyBtn.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.buyBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("buyBtn.Iconimage")));
            this.buyBtn.Iconimage_right = null;
            this.buyBtn.Iconimage_right_Selected = null;
            this.buyBtn.Iconimage_Selected = null;
            this.buyBtn.IconMarginLeft = 0;
            this.buyBtn.IconMarginRight = 0;
            this.buyBtn.IconRightVisible = true;
            this.buyBtn.IconRightZoom = 0D;
            this.buyBtn.IconVisible = true;
            this.buyBtn.IconZoom = 50D;
            this.buyBtn.IsTab = false;
            this.buyBtn.Location = new System.Drawing.Point(0, 133);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.buyBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.buyBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.buyBtn.selected = false;
            this.buyBtn.Size = new System.Drawing.Size(194, 56);
            this.buyBtn.TabIndex = 2;
            this.buyBtn.Text = "   Buy";
            this.buyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buyBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buyBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // BelowLogoPanel
            // 
            this.BelowLogoPanel.BackColor = System.Drawing.Color.LightGray;
            this.BelowLogoPanel.Controls.Add(this.label2);
            this.BelowLogoPanel.Controls.Add(this.label1);
            this.BelowLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BelowLogoPanel.Location = new System.Drawing.Point(0, 85);
            this.BelowLogoPanel.Name = "BelowLogoPanel";
            this.BelowLogoPanel.Size = new System.Drawing.Size(194, 48);
            this.BelowLogoPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Centro Cambiario San Pedro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(59, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "CCSP";
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(194, 85);
            this.logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.bodyPanel);
            this.mainPanel.Controls.Add(this.subHeaderPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(194, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1146, 706);
            this.mainPanel.TabIndex = 1;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.buyUC2);
            this.bodyPanel.Controls.Add(this.excahngeRatesUC1);
            this.bodyPanel.Controls.Add(this.reportsUC2);
            this.bodyPanel.Controls.Add(this.sellUC2);
            this.bodyPanel.Controls.Add(this.panel2);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 133);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1146, 573);
            this.bodyPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 20);
            this.panel2.TabIndex = 1;
            // 
            // subHeaderPanel
            // 
            this.subHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.subHeaderPanel.Controls.Add(this.headingLable);
            this.subHeaderPanel.Controls.Add(this.pictureBox3);
            this.subHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subHeaderPanel.Location = new System.Drawing.Point(0, 85);
            this.subHeaderPanel.Name = "subHeaderPanel";
            this.subHeaderPanel.Size = new System.Drawing.Size(1146, 48);
            this.subHeaderPanel.TabIndex = 1;
            // 
            // headingLable
            // 
            this.headingLable.AutoSize = true;
            this.headingLable.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.headingLable.Location = new System.Drawing.Point(41, 9);
            this.headingLable.Name = "headingLable";
            this.headingLable.Size = new System.Drawing.Size(162, 32);
            this.headingLable.TabIndex = 2;
            this.headingLable.Text = "Dashboard";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1146, 85);
            this.headerPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 31);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1088, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1114, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.headerPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // buyUC2
            // 
            this.buyUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyUC2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.buyUC2.Location = new System.Drawing.Point(0, 0);
            this.buyUC2.Name = "buyUC2";
            this.buyUC2.Size = new System.Drawing.Size(1146, 553);
            this.buyUC2.TabIndex = 5;
            // 
            // excahngeRatesUC1
            // 
            this.excahngeRatesUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excahngeRatesUC1.Location = new System.Drawing.Point(0, 0);
            this.excahngeRatesUC1.Name = "excahngeRatesUC1";
            this.excahngeRatesUC1.Size = new System.Drawing.Size(1146, 553);
            this.excahngeRatesUC1.TabIndex = 4;
            // 
            // reportsUC2
            // 
            this.reportsUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsUC2.Location = new System.Drawing.Point(0, 0);
            this.reportsUC2.Name = "reportsUC2";
            this.reportsUC2.Size = new System.Drawing.Size(1146, 553);
            this.reportsUC2.TabIndex = 3;
            // 
            // sellUC2
            // 
            this.sellUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellUC2.Location = new System.Drawing.Point(0, 0);
            this.sellUC2.Name = "sellUC2";
            this.sellUC2.Size = new System.Drawing.Size(1146, 553);
            this.sellUC2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 706);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.SidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SidebarPanel.ResumeLayout(false);
            this.BelowLogoPanel.ResumeLayout(false);
            this.BelowLogoPanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.subHeaderPanel.ResumeLayout(false);
            this.subHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Panel BelowLogoPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel subHeaderPanel;
        private System.Windows.Forms.Panel headerPanel;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label headingLable;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton reportsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton exchangeRateBtn;
        private Bunifu.Framework.UI.BunifuFlatButton sellBtn;
        private Bunifu.Framework.UI.BunifuFlatButton buyBtn;
        private UserControls.BuyUC buyUC2;
        private UserControls.ExcahngeRatesUC excahngeRatesUC1;
        private UserControls.ReportsUC reportsUC2;
        private UserControls.SellUC sellUC2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

