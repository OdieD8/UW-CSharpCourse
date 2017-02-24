using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    public abstract class JunkFood : Snack
    {
        public readonly int caloriesFromFat;

        public JunkFood(string name, PurchasePrice price, int caloriesFromFat) : base(name, price)
        {
            this.caloriesFromFat = caloriesFromFat;
        }

        public override string ToString()
        {
            StringBuilder currentText = new StringBuilder(base.ToString());
            currentText.Append("Category: Junk Food" + Environment.NewLine);
            currentText.Append("Calories from fat: " + caloriesFromFat + Environment.NewLine);
            return currentText.ToString();
        }
    }
}
