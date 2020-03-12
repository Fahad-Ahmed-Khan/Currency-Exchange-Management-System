using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1.UserControls
{
    public partial class ReportsUC : UserControl
    {
        public ReportsUC()
        {
            InitializeComponent();
        }

        private void ReportsUC_Load(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            reportpanel.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        private void reportpanel_VisibleChanged(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            reportpanel.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }
    }
}
