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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cEDBDataSet.SellTable' table. You can move, or remove it, as needed.
            this.sellTableTableAdapter.Fill(this.cEDBDataSet.SellTable);
            // TODO: This line of code loads data into the 'cEDBDataSet.BuyTable' table. You can move, or remove it, as needed.
            this.buyTableTableAdapter.Fill(this.cEDBDataSet.BuyTable);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

     

     

        private void button1_Click(object sender, EventArgs e)
        {
           // TODO: This line of code loads data into the 'cEDBDataSet.BuyTable' table. You can move, or remove it, as needed.
            this.buyTableTableAdapter.FillBy(this.cEDBDataSet.BuyTable, dateTimePicker1.Value.AddDays(-1), dateTimePicker2.Value);


            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cEDBDataSet.SellTable' table. You can move, or remove it, as needed.
            this.sellTableTableAdapter.FillBy(this.cEDBDataSet.SellTable, dateTimePicker3.Value.AddDays(-1), dateTimePicker4.Value.AddDays(1));

            this.reportViewer2.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cEDBDataSet.SellTable' table. You can move, or remove it, as needed.
            this.sellTableTableAdapter.Fill(this.cEDBDataSet.SellTable);
            // TODO: This line of code loads data into the 'cEDBDataSet.BuyTable' table. You can move, or remove it, as needed.
            this.buyTableTableAdapter.Fill(this.cEDBDataSet.BuyTable);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
