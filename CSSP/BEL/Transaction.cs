using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Transaction
    {

        public int ID { get; set; }
        public double dolars { get; set; }
        public double exhangeRate { get; set; }
        public double pesos { get; set; }
        public DateTime dateTime { get; set; }


        public int ExchangeID { get; set; }
        public double exchangeRate { get; set; }
        public double lowerLimit { get; set; }
        public double upperLimit { get; set; }




    }
}
