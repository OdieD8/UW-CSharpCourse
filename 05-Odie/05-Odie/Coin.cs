//Exercise 05
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Odie
{
    class Coin
    {
        private Denomination _coin;
        public enum Denomination { SLUG = 0, NICKEL = 5, DIME = 10, QUARTER = 25, HALFDOLLAR = 50 }

        public Coin()
        {
            _coin = Denomination.SLUG;
        }

        public Coin(Denomination CoinEnumeral)
        {
            _coin = CoinEnumeral;
        }

        public Coin(string CoinName)
        {
            Denomination coinEnumeral;
            if (Enum.IsDefined(typeof(Denomination), CoinName) && Enum.TryParse<Denomination>(CoinName, out coinEnumeral))
            {
                _coin = coinEnumeral;
            }
            else
            {
                _coin = Coin.Denomination.SLUG;
            }
        }

        public Coin(decimal CoinValue)
        {
            Denomination castFromValue = (Denomination)(CoinValue * 100);
            switch (castFromValue)
            {
                case Denomination.NICKEL:
                case Denomination.DIME:
                case Denomination.QUARTER:
                case Denomination.HALFDOLLAR:
                    _coin = castFromValue;
                    break;
                default:
                    _coin = Denomination.SLUG;
                    break;
            }
        }

        public decimal ValueOf
        {
            get
            {
                return (decimal)_coin / 100m;
            }
        }

        public Denomination CoinEnumeral
        {
            get
            {
                return _coin;
            }
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(Denomination), _coin);
        }
    }
}
