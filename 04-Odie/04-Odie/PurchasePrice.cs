//Exercise 04
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Odie
{
    class PurchasePrice
    {
        private decimal _purchasePrice;

        public PurchasePrice()
        {
            _purchasePrice = 0;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice;
        }

        [Obsolete]
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        public int Price
        {
            get { return (int)_purchasePrice * 100; }
            set { _purchasePrice = (decimal)value * 0.01m; }
        }

        public decimal PriceDecimal
        {
            get { return _purchasePrice; }
            set { _purchasePrice = value; }
        }
    }
}
