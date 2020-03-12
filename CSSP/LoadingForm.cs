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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //bunifuProgressBar1.Value += 1;
            //if (bunifuProgressBar1.Value >= 99)
            {
                timer1.Stop();
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
                
            }
                
        }
    }
}
