using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    abstract class HealthFood : Snack
    {
        public HealthFood(string name, PurchasePrice price, DateTime freshUntil) : base(name, price)
        {

        }
    }
}
