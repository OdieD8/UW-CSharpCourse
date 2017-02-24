using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    public class FoodLocker
    {
        public enum SnackObject { Apple, Banana, CandyBar, PotatoChips };

        public FoodLocker() { }

        public int Size
        {
            get; set;
        }

        public List<Snack> Store;

        private Random randomSnackItem = new Random();

        public void Stock()
        {
            Store = new List<Snack>();
            Random randomFoodLockerSize = new Random();
            int foodLockerSize = randomFoodLockerSize.Next(1, 12);
            Size = foodLockerSize;

            for (int i = 0; i <= Size; i ++)
            {
                var currentSnack = getRandomSnackObject();

                switch (currentSnack)
                {
                    case SnackObject.Apple:
                        Store.Add(new Apple("Honeycrisp Apple", new PurchasePrice(0.50m)));
                        break;

                    case SnackObject.Banana:
                        Store.Add(new Banana("Bonita Banana", new PurchasePrice(0.70m)));
                        break;

                    case SnackObject.CandyBar:
                        Store.Add(new CandyBar("Three Musketeers", new PurchasePrice(1.25m)));
                        break;

                    case SnackObject.PotatoChips:
                        Store.Add(new PotatoChips("Cool Ranch Doritos", new PurchasePrice(1.05m)));
                        break;

                    default:
                        throw new ArgumentException("Could not find snack type");
                }
            }
        }

        private SnackObject getRandomSnackObject()
        {
            Array snackItems = Enum.GetValues(typeof(SnackObject));
            SnackObject snack = (SnackObject)snackItems.GetValue(randomSnackItem.Next(snackItems.Length));
            return snack;
        }
    }
}
