using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    class CandyBar : JunkFood
    {
        private string _name;
        private PurchasePrice _price;

        public CandyBar(string name, PurchasePrice price) : base(name, price, 500)
        {
            this._name = name;
            this._price = price;
        }
    }
}
