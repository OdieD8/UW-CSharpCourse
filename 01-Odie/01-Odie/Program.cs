//Exercise 01
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Odie
{
    class Program
    {
        static void Main(string[] args)
        {
            int sodaPrice = 35;
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.Write($"Please insert {sodaPrice} cents: ");
            int cents = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"You have inserted {cents} cents");
            if (cents < 35)
            {
                Console.WriteLine("That's not enough for a soda");
            }
            else
            {
                Console.WriteLine("Thanks. Here is your soda");
            }
            Console.WriteLine();
        }
    }
}
