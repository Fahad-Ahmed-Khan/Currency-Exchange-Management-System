using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }



        private void switchTab(UserControl activeForm, string heading, BunifuFlatButton button)
        {
            buyUC2.Hide();
          //  dashboardUC1.Hide();
            sellUC2.Hide();
            reportsUC2.Hide();
            excahngeRatesUC1.Hide();
            activeForm.Show();
            headingLable.Text = heading;
            buyBtn.BorderStyle = BorderStyle.None;
            sellBtn.BorderStyle = BorderStyle.None;
            exchangeRateBtn.BorderStyle = BorderStyle.None;
            reportsBtn.BorderStyle = BorderStyle.None;
           
            button.BorderStyle = BorderStyle.FixedSingle;
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
             
        }

       
  

        private void MainForm_Load(object sender, EventArgs e)
        {
            buyBtn_Click(null, null);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            switchTab(buyUC2, "Buy", buyBtn);
            
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            switchTab(sellUC2, "Sell", sellBtn);
        }

        private void exchangeRateBtn_Click(object sender, EventArgs e)
        {
            switchTab(excahngeRatesUC1, "Exchange Rates", exchangeRateBtn);
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            switchTab(reportsUC2, "Reports", reportsBtn);
        }
    }
}
