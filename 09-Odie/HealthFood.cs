using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    public abstract class HealthFood : Snack
    {
        public readonly DateTime freshUntil;

        public HealthFood(string name, PurchasePrice price, DateTime freshUntil) : base(name, price)
        {
            this.freshUntil = freshUntil;
        }

        public override string ToString()
        {
            StringBuilder currentText = new StringBuilder(base.ToString());
            currentText.Append("Category: Health Food" + Environment.NewLine);
            currentText.Append("Fresh until: " + freshUntil + Environment.NewLine);
            return currentText.ToString();
        }
    }
}
