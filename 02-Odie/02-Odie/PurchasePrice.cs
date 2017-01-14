using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odie
{
    class PurchasePrice
    {
        private int _purchasePrice;

        public PurchasePrice()
        {
            _purchasePrice = 0;
        }

        public PurchasePrice(int initialPrice)
        {
            _purchasePrice = initialPrice;
        }

        public int Price
        {
            get { return _purchasePrice; }
            set { _purchasePrice = value; }
        }
    }
}
