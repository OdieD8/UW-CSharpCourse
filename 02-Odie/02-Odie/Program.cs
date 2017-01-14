//Exercise 02
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odie
{
    class Program
    {
        static void Main(string[] args)
        {
            // instatiate PurchasePrice object and set sode price
            PurchasePrice sodaPrice = new PurchasePrice(35);
            SodaMachineRack sodaRack = new SodaMachineRack();
            string currentSoda = "orange";

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.Write($"Please insert {sodaPrice.Price} cents: ");
            int cents = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"You have inserted {cents} cents");
            if (cents < 35)
            {
                Console.WriteLine("That's not enough for a soda");
            }
            else
            {
                sodaRack.RemoveCanOf(currentSoda);
                Console.WriteLine($"Thanks. Here is your {currentSoda} soda");
            }
            Console.WriteLine();
            // Seeing when more cans than are available are attempted to be removed
            Console.WriteLine("Orange soda rack empty? " + sodaRack.IsEmpty("orange"));
            sodaRack.RemoveCanOf(currentSoda);
            Console.WriteLine("Orange soda rack empty? " + sodaRack.IsEmpty("orange"));
            sodaRack.RemoveCanOf(currentSoda);
            Console.WriteLine("Orange soda rack empty? " + sodaRack.IsEmpty("orange"));
            sodaRack.RemoveCanOf(currentSoda);
            Console.WriteLine();
        }
    }
}
