//Exercise 4
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _04_Odie
{
    class SodaMachineRack
    {
        private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length];

        //private int _regular;
        //private int _orange;
        //private int _lemon;
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
                Flavor flavor;
                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeAdded))
                {
                    flavor = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeAdded);
                    int flavorIndex = (int)flavor;
                    rack[flavorIndex]++;
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
                Flavor flavor;
                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeRemoved))
                {
                    flavor = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeRemoved);
                    int flavorIndex = (int)flavor;
                    rack[flavorIndex]--;
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
            foreach (int flavorValue in Enum.GetValues(typeof(Flavor)))
            {
                rack[flavorValue] = _full;
            }
        }

        public void EmptyCanRackOf(string flavorOfBinToBeEmptied)
        {
            flavorOfBinToBeEmptied = flavorOfBinToBeEmptied.ToUpper();
            if (Enum.IsDefined(typeof(Flavor), flavorOfBinToBeEmptied))
            {
                Flavor flavor = (Flavor)Enum.Parse(typeof(Flavor), flavorOfBinToBeEmptied);
                int flavorIndex = (int)flavor;
                rack[flavorIndex] = _empty;
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
            Flavor flavor;
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToCheck))
            {
                flavor = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck);
                int flavorIndex = (int)flavor;
                isFull = rack[flavorIndex] == _full;
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
            Flavor flavor;
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToCheck))
            {
                flavor = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck);
                int flavorIndex = (int)flavor;
                isEmpty = rack[flavorIndex] == _empty;
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
            Console.WriteLine();
            foreach (string flavorName in Enum.GetNames(typeof(Flavor))) 
            {
                Flavor flavor = (Flavor)Enum.Parse(typeof(Flavor), flavorName);
                int flavorIndex = (int)flavor;
                Console.WriteLine($"{flavorName}: {rack[flavorIndex]}");
            }
            Console.WriteLine();
        }
    }
}
