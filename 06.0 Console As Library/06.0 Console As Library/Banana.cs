using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    class Banana : HealthFood
    {
        private string _name;
        private PurchasePrice _price;

        public Banana(string name, PurchasePrice price) : base(name, price, DateTime.Now.AddDays(6))
        {
            this._name = name;
            this._price = price;
        }
    }
}
