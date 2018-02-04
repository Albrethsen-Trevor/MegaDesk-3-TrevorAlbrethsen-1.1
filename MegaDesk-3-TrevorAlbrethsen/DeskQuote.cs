using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TrevorAlbrethsen
{
    class DeskQuote
    {
        private int rushDays;
        public int getRushDays
        {
            get
            {
                return this.rushDays;
            }
            set
            {
                this.rushDays = value;
            }
        }

        private string customerName;
        public string getCustomerName
        {
            get
            {
                return this.customerName;
            }
            set
            {
                this.customerName = value;
            }
        }

        public void saveQuote(AddQuote addQuote)
        {
            Desk desk = new Desk();
        }


    }
}
