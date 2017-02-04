using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._4_Exceptions
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
            box = SeedMoney;
        }

        // put a coin in the coin box
        public void Deposit(Coin ACoin)
        {
            box.Add(ACoin);
        }

        // take a coin of the specified denomination out of the box
        public Boolean Withdraw(Coin.Denomination ACoinDenomination)
        {
            var aCoin =
                from firstCoin in box
                where firstCoin.DenominationEnumeral == ACoinDenomination
                select firstCoin;

            Boolean result = false;
            if (aCoin.Count() > 0)
            {
                result = box.Remove(aCoin.First());
            }
            return result;
        }

        private int coinCount(Coin.Denomination denominationEnumeral)
        {
            var roll =
                    from coin in box
                    where coin.DenominationEnumeral == denominationEnumeral
                    select coin;

            return roll.Count();
        }

        // number of half dollars in the coin box
        public int HalfDollarCount
        {
            get
            {
                return coinCount(Coin.Denomination.HALFDOLLAR);
            }
        }

        // number of quarters in the coin box
        public int QuarterCount
        {
            get
            {
                return coinCount(Coin.Denomination.QUARTER);
            }
        }

        // number of dimes in the coin box
        public int DimeCount
        {
            get
            {
                return coinCount(Coin.Denomination.DIME);
            }
        }

        // number of nickels in the coin box
        public int NickelCount
        {
            get
            {
                return coinCount(Coin.Denomination.NICKEL);
            }
        }
        
        // number of worthless coins in the coin box
        public int SlugCount
        {
            get
            {
                return coinCount(Coin.Denomination.SLUG);
            }
        }

        // total amount of money in the coin box
        public decimal ValueOf
        {
            get
            {
                decimal result =
                    HalfDollarCount * (decimal)Coin.Denomination.HALFDOLLAR/100M +
                    QuarterCount * (decimal)Coin.Denomination.QUARTER / 100M +
                    DimeCount * (decimal)Coin.Denomination.DIME / 100M +
                    NickelCount * (decimal)Coin.Denomination.NICKEL / 100M;
                return result;

            }
        }

    }
}
