using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    public class Apple : HealthFood
    {
        private string _name;
        private PurchasePrice _price;
        
        public Apple(string name, PurchasePrice price) : base(name, price, DateTime.Now.AddDays(10))
        {
            this._name = name;
            this._price = price;
        }

        public override string ToString()
        {
            return base.ToString() + "I might give you an A";
        }
    }
}
