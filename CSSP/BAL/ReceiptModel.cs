using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrinterUtility;

namespace CSSP
{
    public class ReceiptModel
    {
        public static void printReceipt(string receiptType, double dolars, double pesos, double exchangeRate)
        {
            PrinterUtility.EscPosEpsonCommands.EscPosEpson obj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();
            byte[] BytesValue = Encoding.ASCII.GetBytes(" ");
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.DoubleHeight2());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.FontSelect.FontA());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Centro Cambiario San Pedro\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.Nomarl());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Recibo del cliente\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Left());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("-----------------------------\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(DateTime.Now.ToString() + "\n"));
            if (receiptType == "buy")
                BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Compra de Dolares\n"));
            else
                BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Venta de Dolares\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Dolares: $ " + string.Format("{0:#,##0.00}", double.Parse(dolars.ToString())) + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Pesos: $ " + string.Format("{0:#,##0.00}", double.Parse(pesos.ToString())) + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Tipo de cambio: " + string.Format("{0:#,##0.00}", double.Parse(exchangeRate.ToString())) + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("-----------------------------\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(" \n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("\n\n\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, cutPage());

            PrintReceipt(BytesValue);


        }

        private static void PrintReceipt(byte[] BytesValue)
        {
            int fileNo = 1;
            l1:
            string fileName = ".\\tmpPrint" + fileNo + ".print";
            if (File.Exists(fileName))
                try
                {
                    File.Delete(fileName);
                }
                catch
                {
                    fileNo++;
                    goto l1;
                }
                
            File.WriteAllBytes(fileName, BytesValue);

            RawPrinterHelper.SendFileToPrinter(GetDefaultPrinter(), fileName);
            try
            {
                File.Delete(fileName);
            }
            catch
            {

            }
        }

        private static byte[] cutPage()
        {
            List<byte> oby = new List<byte>();
            oby.Add(Convert.ToByte(Convert.ToChar(0x10)));
            oby.Add(Convert.ToByte('v'));
            oby.Add((byte)32);
            return oby.ToArray();
        }

        private static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }
    }
}
