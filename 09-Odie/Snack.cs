using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    public abstract class Snack
    {
        public readonly PurchasePrice price;
        public readonly string name;

        public Snack(string name, PurchasePrice price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return string.Format($"Type : {name}, Cost {price.PriceDecimal:c}" + Environment.NewLine);
        }
    }
}
