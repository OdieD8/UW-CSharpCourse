//Exercise 05
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Odie
{
    class CoinBox
    {
        private List<Coin> box;

        // constructor to create an empty coin box
        public CoinBox()
        {
            box = new List<Coin>();
        }

        // constructor to create a coin box with some coins in it
        public CoinBox(List<Coin> SeedMoney)
        {
            foreach (var coin in SeedMoney)
            {
                box.Add(coin);
            }
        }

        // put a coin in the coin box
        public void Deposit(Coin ACoin)
        {
            box.Add(ACoin);
        }

        // take a coin of the specified denomination out of the box
        public Boolean Withdraw(Coin.Denomination ACoinDenomination)
        {
            bool coinWithDrawn = false;
            var coinToRemove =
                from coin in box
                where coin.ToString() == ACoinDenomination.ToString()
                select coin;

            if (coinToRemove.Any())
            {
                box.Remove(coinToRemove.First());
                coinWithDrawn = true;
            }
            return coinWithDrawn;
        }

        // number of half dollars in the coin box
        public int HalfDollarCount
        {
            get
            {
                int count = Counts(Coin.Denomination.HALFDOLLAR);
                return count;
            }
        }

        // number of quarters in the coin box
        public int QuarterCount
        {
            get
            {
                int count = Counts(Coin.Denomination.QUARTER);
                return count;
            }
        }

        // number of dimes in the coin box
        public int DimeCount
        {
            get
            {
                int count = Counts(Coin.Denomination.DIME);
                return count;
            }
        }

        // number of nickels in the coin box
        public int NickelCount
        {
            get
            {
                int count = Counts(Coin.Denomination.NICKEL);
                return count;
            }
        }

        // number of worthless coins in the coin box
        public int SlugCount
        {
            get
            {
                int count = Counts(Coin.Denomination.SLUG);
                return count;
            }
        }

        public int Counts(Coin.Denomination currentCoin)
        {
            int count = 0;
            var getCount =
                from coin in box
                where coin.ToString() == currentCoin.ToString()
                select coin;

            foreach (var coin in getCount)
            {
                count++;
            }
            return count;
        }

        // total amount of money in the coin box
        public decimal ValueOf
        {
            get
            {
                decimal totalValue = 0m;
                foreach (var coin in box)
                {
                    totalValue += coin.ValueOf;
                }
                return totalValue;
            }
        }
    }
}
