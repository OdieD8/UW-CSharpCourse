//Exercise 05
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05_Odie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

            PurchasePrice sodaPrice = new PurchasePrice(0.35m);
            SodaMachineRack sodaRack = new SodaMachineRack();
            CoinBox box = new CoinBox();

            bool orderMore = true;
            do
            {
                sodaRack.DisplayCanRack();

                Console.Write($"Soda Price is ${sodaPrice.PriceDecimal}, \n please insert a Nickel, Dime, Quarter, or HalfDollar: ");

                decimal userEnteredAmount = 0m;
                while (userEnteredAmount < sodaPrice.PriceDecimal)
                {
                    Console.WriteLine();
                    string coinInserted = Console.ReadLine().ToUpper();
                    Coin coin = new Coin(coinInserted);
                    Console.WriteLine($"You have inserted: {coin.ValueOf.ToString("C", CultureInfo.CurrentCulture)}");
                    box.Deposit(coin);

                    userEnteredAmount += coin.ValueOf;
                    if (sodaPrice.PriceDecimal - userEnteredAmount < 0)
                    {
                        Console.WriteLine("That's enough for a soda!");
                    }
                    else
                    {
                        Console.WriteLine($"Additional ${sodaPrice.PriceDecimal - userEnteredAmount} required for a soda");
                    }

                    if (userEnteredAmount < sodaPrice.PriceDecimal)
                    {
                        Console.WriteLine();
                        Console.Write("Please insert more coins: ");
                    }
                    else if (userEnteredAmount > sodaPrice.PriceDecimal)
                    {
                        Console.WriteLine($"Here is your change of ${userEnteredAmount - sodaPrice.PriceDecimal}");
                    }
                    Console.WriteLine();
                }

                bool canDispensed = false;
                while (!canDispensed)
                {
                    Console.Write("Please select soda flavor: 1-Regular, 2-Orange, 3-Lemon ");
                    int flavorNumber = Convert.ToInt16(Console.ReadLine());
                    Flavor flavorSelected = new Flavor();

                    switch (flavorNumber)
                    {
                        case 1:
                            flavorSelected = Flavor.REGULAR;
                            break;
                        case 2:
                            flavorSelected = Flavor.ORANGE;
                            break;
                        case 3:
                            flavorSelected = Flavor.LEMON;
                            break;
                    }

                    if (!Enum.IsDefined(typeof(Flavor), flavorSelected))
                    {
                        Console.WriteLine("Please select a valid soda");
                    }
                    else
                    {
                        if (!sodaRack.IsEmpty(flavorSelected))
                        {
                            sodaRack.RemoveCanOf(flavorSelected);
                            Console.WriteLine($"Thanks. Here is your {flavorSelected} soda");
                            canDispensed = true;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, there are no {flavorSelected} sodas available");
                        }
                    }
                    Console.WriteLine();
                }

                Console.Write("Would you like to order another? (y/n) ");
                string response = Console.ReadLine().ToUpper().Trim();
                if (response.StartsWith("N")) orderMore = false;
                else if (!response.StartsWith("Y")) Console.WriteLine("Invalid response, please choose y/n");
                Console.WriteLine();
            }
            while (orderMore == true);
            Console.WriteLine("***** CoinBox Counts *****");
            Console.WriteLine("Nickels: " + box.NickelCount);
            Console.WriteLine("Dimes: " + box.DimeCount);
            Console.WriteLine("Quarters: " + box.QuarterCount);
            Console.WriteLine("HalfDollars: " + box.HalfDollarCount);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Total Amount in CoinBox: {0:C}", box.ValueOf);
            Console.WriteLine();
        }
    }
}
