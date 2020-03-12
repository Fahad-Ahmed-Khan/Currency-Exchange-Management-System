using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;
using CSSP;

namespace WindowsFormsApp1.UserControls
{
    public partial class SellUC : UserControl
    {
        public SellUC()
        {
            InitializeComponent();
        }
        BAL.CurrencyExchange currencyExchange = new BAL.CurrencyExchange();
        BEL.Transaction ExchangeRate;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DoTransaction();
        }

        private void ResetForm()
        {
            dolarTxtBox.Text = 0.ToString();
            pesoTxtBox.Text = 0.ToString();
            exchangeRateTxtBox.Text = ExchangeRate.exchangeRate.ToString();

            dolarTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(dolarTxtBox.Text));
            exchangeRateTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(exchangeRateTxtBox.Text));
            pesoTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(pesoTxtBox.Text));

            dolarTxtBox.Focus();
        }
        private void SellUC_Load(object sender, EventArgs e)
        {
            
        }

        private void dolarTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            CalculatePeso();
        }
        private void CalculatePeso()
        {
            try
            {
                double dolars = Convert.ToDouble(dolarTxtBox.Text);
                double exchangeRate = Convert.ToDouble(exchangeRateTxtBox.Text);
             

                pesoTxtBox.Text = (dolars * exchangeRate).ToString();
                pesoTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(pesoTxtBox.Text));
            }
            catch
            {

            }
        }

        private void exchangeRateTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            CalculatePeso();
        }

        private void SellUC_VisibleChanged(object sender, EventArgs e)
        {
            sellRecorDGV.DataSource = currencyExchange.getallRecords("sell");
            ExchangeRate = currencyExchange.getExchangeRate("sell");
            ResetForm();

            this.sellRecorDGV.Columns[1].DefaultCellStyle.Format = "N2";
            this.sellRecorDGV.Columns[2].DefaultCellStyle.Format = "N2";
            this.sellRecorDGV.Columns[3].DefaultCellStyle.Format = "N2";

            dolarTxtBox.Focus();

        }


        private void DoTransaction()
        {
            exchangeRateTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(exchangeRateTxtBox.Text));
            pesoTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(pesoTxtBox.Text));


            BEL.Transaction transaction = new BEL.Transaction();
            try
            {
                transaction.dolars = Convert.ToDouble(dolarTxtBox.Text);
                transaction.exchangeRate = Convert.ToDouble(exchangeRateTxtBox.Text);
                transaction.pesos = Convert.ToDouble(pesoTxtBox.Text);

            }
            catch
            {
                MessageBox.Show("Input must be in numbers", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (transaction.exchangeRate < ExchangeRate.lowerLimit)
            {
                MessageBox.Show("The exchange rate must be greater than "+ExchangeRate.lowerLimit, "Invalid Exchange Rate", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            if (transaction.dolars <= 0)
                return;

            if (currencyExchange.addTransaction("sell", transaction) > 0)
            {
                //Show in gridview,
                //print recipt
                sellRecorDGV.DataSource = currencyExchange.getallRecords("sell");
                if (printChkBox.Checked)
                    ReceiptModel.printReceipt("sell", transaction.dolars, transaction.pesos, transaction.exchangeRate);

                ResetForm();
            }
        }

        private void dolarTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    dolarTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(dolarTxtBox.Text));
                    exchangeRateTxtBox.Focus();
                }
                catch
                {
                    MessageBox.Show("Invalid amount in dolars", "Invalid Input");
                    dolarTxtBox.Focus();
                }
            }
        }

        private void exchangeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void customerNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void exchangeRateTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    exchangeRateTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(exchangeRateTxtBox.Text.Trim()));
                    pesoTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(pesoTxtBox.Text.Trim()));
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid number in exchange rate. " + ex.Message, "Invalid Input");
                    exchangeRateTxtBox.Focus();
                    return;
                }

                DoTransaction();
            }
        }

        private void dolarTxtBox_Leave(object sender, EventArgs e)
        {
            try
            {
                dolarTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(dolarTxtBox.Text));
            }
            catch
            {
                MessageBox.Show("Invalid amount in dolars", "Invalid Input");
                dolarTxtBox.Focus();
            }
        }

        private void exchangeRateTxtBox_Leave(object sender, EventArgs e)
        {
            try
            {
                exchangeRateTxtBox.Text = string.Format("{0:#,##0.00}", double.Parse(exchangeRateTxtBox.Text));
            }
            catch
            {
                MessageBox.Show("Invalid number in exchange rate", "Invalid Input");
                exchangeRateTxtBox.Focus();
            }
        }
    }
}
