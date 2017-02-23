using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    abstract class JunkFood : Snack
    {
        public JunkFood(string name, PurchasePrice price, int caloriesFromFat) : base(name, price)
        {

        }
    }
}
