namespace WindowsFormsApp1.UserControls
{
    partial class ReportsUC
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
            this.reportpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // reportpanel
            // 
            this.reportpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportpanel.Location = new System.Drawing.Point(0, 0);
            this.reportpanel.Name = "reportpanel";
            this.reportpanel.Size = new System.Drawing.Size(1003, 516);
            this.reportpanel.TabIndex = 0;
            this.reportpanel.VisibleChanged += new System.EventHandler(this.reportpanel_VisibleChanged);
            // 
            // ReportsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportpanel);
            this.Name = "ReportsUC";
            this.Size = new System.Drawing.Size(1003, 516);
            this.Load += new System.EventHandler(this.ReportsUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reportpanel;
    }
}
