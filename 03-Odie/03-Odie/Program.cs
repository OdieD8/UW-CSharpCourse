//Exercise 03
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Odie
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchasePrice sodaPrice = new PurchasePrice(0.35m);
            SodaMachineRack sodaRack = new SodaMachineRack();
            Flavor currentFlavor = Flavor.ORANGE;

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.Write($"Please insert ${sodaPrice.Price}: ");
            decimal userEnteredAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"You have inserted ${userEnteredAmount}");
            if (userEnteredAmount < sodaPrice.Price)
            {
                Console.WriteLine("That's not enough for a soda");
            }
            else
            {
                sodaRack.RemoveCanOf(currentFlavor);
                Console.WriteLine($"Thanks. Here is your {currentFlavor} soda");
            }
            Console.WriteLine();
        }
    }
}
