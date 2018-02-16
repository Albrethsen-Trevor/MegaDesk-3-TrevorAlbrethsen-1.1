 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TrevorAlbrethsen_1_1
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public int RushOrder { get; set; }
        public int FinalPrice { get; set; }
        public string CustomerPrice(decimal FinalPrice)
        {
            string CustomerPriceTotal;
            //int dollars = FinalPrice / 100;
            //int cents = FinalPrice % 100;
            //CustomerPriceTotal = "$" + dollars.ToString() + "." + cents.ToString();

            CustomerPriceTotal = FinalPrice.ToString("C");

            return CustomerPriceTotal;
        }

        const int Oak = 200;
        const int Laminate = 100;
        const int Pine = 50;
        const int Rosewood = 300;
        const int Veneer = 125;
    }
}
