//Exercise 05
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _05_Odie
{
    class SodaMachineRack
    {
        private Dictionary<Flavor, int> rack = new Dictionary<Flavor, int>();

        private const int _full = 3;
        private const int _empty = 0;

        public SodaMachineRack()
        {
            FillTheCanRack();
        }

        public void AddCanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Console.WriteLine($"Could not add {FlavorOfCanToBeAdded} to SodaMachineRack");
            }
            else
            {
                Flavor currentFlavor = FlavorOps.ToFlavor(FlavorOfCanToBeAdded);
                if (rack.ContainsKey(currentFlavor)) 
                {
                    rack[currentFlavor]++;
                }
                else
                {
                    Console.WriteLine($"Flavor not recognized: {FlavorOfCanToBeAdded}");
                }
            }
        }

        public void AddCanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddCanOf(FlavorOfCanToBeAdded.ToString());
        }

        public void RemoveCanOf(string FlavorOfCanToBeRemoved)
        {
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Console.WriteLine($"Could not remove {FlavorOfCanToBeRemoved} from SodaMachineRack");
            }
            else
            {
                Flavor currentFlavor = FlavorOps.ToFlavor(FlavorOfCanToBeRemoved);
                if (rack.ContainsKey(currentFlavor))
                {
                    rack[currentFlavor]--;
                }
                else
                {
                    Console.WriteLine($"Flavor not recognized: {FlavorOfCanToBeRemoved}");
                }
            }
        }

        public void RemoveCanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveCanOf(FlavorOfCanToBeRemoved.ToString());
        }

        public void FillTheCanRack()
        {
            foreach (Flavor flavorValue in FlavorOps.AllFlavors())
            {
                rack[flavorValue] = _full;
            }
        }

        public void EmptyCanRackOf(string flavorOfBinToBeEmptied)
        {
            flavorOfBinToBeEmptied = flavorOfBinToBeEmptied.ToUpper();
            Flavor currentFlavor = FlavorOps.ToFlavor(flavorOfBinToBeEmptied);
            if (rack.ContainsKey(currentFlavor))
            {
                rack[currentFlavor] = _empty;
            }
            else
            {
                Console.WriteLine($"Could not find flavor: {flavorOfBinToBeEmptied}");
            }
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString());
        }

        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            bool isFull = false;
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Flavor currentFlavor = FlavorOps.ToFlavor(FlavorOfBinToCheck);
            if (rack.ContainsKey(currentFlavor))
            {
                isFull = rack[currentFlavor] == _full;
            }
            else
            {
                Console.WriteLine("Could not find flavor");
            }
            return isFull;
        }

        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            return IsFull(FlavorOfBinToCheck.ToString());
        }

        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            bool isEmpty = false;
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Flavor currentFlavor = FlavorOps.ToFlavor(FlavorOfBinToCheck);
            if (rack.ContainsKey(currentFlavor))
            {
                isEmpty = rack[currentFlavor] == _empty;
            }
            else
            {
                Console.WriteLine("Could not find flavor");
            }
            return isEmpty;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            return IsEmpty(FlavorOfBinToCheck.ToString());
        }

        public void DisplayCanRack()
        {
            Console.WriteLine(".NET C# Soda Vending Machine Contents: ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            foreach (Flavor flavorName in FlavorOps.AllFlavors()) 
            {
                Console.WriteLine($"{flavorName}: {rack[flavorName]}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
        }
    }
}
