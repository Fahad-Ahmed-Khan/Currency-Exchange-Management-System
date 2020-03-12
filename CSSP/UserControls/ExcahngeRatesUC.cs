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
    public partial class ExcahngeRatesUC : UserControl
    {
        public ExcahngeRatesUC()
        {
            InitializeComponent();
        }
        BAL.CurrencyExchange currencyExchange = new BAL.CurrencyExchange();
        private void SellUserControl_Load(object sender, EventArgs e)
        {
            BEL.Transaction trans = currencyExchange.getExchangeRate("sell");
            sellexchangeRateTxt.Text = trans.exchangeRate.ToString();
            selllowerLimitTxt.Text = trans.lowerLimit.ToString();
            


            trans = currencyExchange.getExchangeRate("buy");
            buyexchangeRateTxt.Text = trans.exchangeRate.ToString();
            buyupperLimitTxt.Text = trans.upperLimit.ToString();

            sellexchangeRateTxt.Text = string.Format("{0:#,##0.00}", double.Parse(sellexchangeRateTxt.Text));
            selllowerLimitTxt.Text = string.Format("{0:#,##0.00}", double.Parse(selllowerLimitTxt.Text));

            buyexchangeRateTxt.Text = string.Format("{0:#,##0.00}", double.Parse(buyexchangeRateTxt.Text));
            buyupperLimitTxt.Text = string.Format("{0:#,##0.00}", double.Parse(buyupperLimitTxt.Text));
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            UpdateExchangeRates();
        }

        private void UpdateExchangeRates()
        {
            BEL.Transaction sellRates = new BEL.Transaction
            {
                exchangeRate = Convert.ToDouble(sellexchangeRateTxt.Text),
                lowerLimit = Convert.ToDouble(selllowerLimitTxt.Text),
                upperLimit = 0,
            };

            if (!(sellRates.exchangeRate >= sellRates.lowerLimit))
            {
                MessageBox.Show("The Exchange Rate must be greater than or equal lower limit (" + sellRates.lowerLimit + ")", "Invalid Sell Exchange Rate", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            BEL.Transaction buyRates = new BEL.Transaction
            {
                exchangeRate = Convert.ToDouble(buyexchangeRateTxt.Text),
                upperLimit = Convert.ToDouble(buyupperLimitTxt.Text),
            };

            if (buyRates.exchangeRate > buyRates.upperLimit)
            {
                MessageBox.Show("The Buying Exchange Rate must be less than or equal to lower limit (" + buyRates.upperLimit + ")", "Invalid Buy Exchange Rate", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            currencyExchange.updateExchangeRates(1, buyRates);
            currencyExchange.updateExchangeRates(2, sellRates);

            MessageBox.Show("Exchange rates updated successfully", "Rates Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SellUserControl_VisibleChanged(object sender, EventArgs e)
        {
            SellUserControl_Load(null, null);
            buyexchangeRateTxt.Focus();
           

        }

        private void buyexchangeRateTxt_Leave(object sender, EventArgs e)
        {
            buyexchangeRateTxt.Text = string.Format("{0:#,##0.00}", double.Parse(buyexchangeRateTxt.Text));
        }

        private void buyupperLimitTxt_Leave(object sender, EventArgs e)
        {
            buyupperLimitTxt.Text = string.Format("{0:#,##0.00}", double.Parse(buyupperLimitTxt.Text));
        }

        private void sellexchangeRateTxt_Leave(object sender, EventArgs e)
        {
            sellexchangeRateTxt.Text = string.Format("{0:#,##0.00}", double.Parse(sellexchangeRateTxt.Text));
            
        }

        private void selllowerLimitTxt_Leave(object sender, EventArgs e)
        {
            selllowerLimitTxt.Text = string.Format("{0:#,##0.00}", double.Parse(selllowerLimitTxt.Text));

        }

        private void buyexchangeRateTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    buyexchangeRateTxt.Text = string.Format("{0:#,##0.00}", double.Parse(buyexchangeRateTxt.Text));
                    buyupperLimitTxt.Focus();
                }
                catch
                {
                    MessageBox.Show("Invalid amount in dolars", "Invalid Input");
                    buyexchangeRateTxt.Focus();
                }
            }
        }

        private void buyupperLimitTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    buyupperLimitTxt.Text = string.Format("{0:#,##0.00}", double.Parse(buyupperLimitTxt.Text));
                    sellexchangeRateTxt.Focus();
                }
                catch
                {
                    MessageBox.Show("Invalid amount in dolars", "Invalid Input");
                    buyupperLimitTxt.Focus();
                }
            }
        }

        private void sellexchangeRateTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    sellexchangeRateTxt.Text = string.Format("{0:#,##0.00}", double.Parse(sellexchangeRateTxt.Text));
                    selllowerLimitTxt.Focus();
                }
                catch
                {
                    MessageBox.Show("Invalid amount in dolars", "Invalid Input");
                    sellexchangeRateTxt.Focus();
                }
            }
        }

        private void selllowerLimitTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    selllowerLimitTxt.Text = string.Format("{0:#,##0.00}", double.Parse(selllowerLimitTxt.Text));
                    UpdateExchangeRates();
                }
                catch
                {
                    MessageBox.Show("Invalid amount in Selling Lower Limit", "Invalid Input");
                    selllowerLimitTxt.Focus();
                }
            }
        }
    }
}
