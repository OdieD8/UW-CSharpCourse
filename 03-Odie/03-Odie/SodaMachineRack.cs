//Exercise 3
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _03_Odie
{
    class SodaMachineRack
    {
        private int _regular;
        private int _orange;
        private int _lemon;

        public SodaMachineRack()
        {
            FillTheCanRack();
        }

        public void AddCanOf(string FlavorOfCanToBeAdded)
        {
            if (FlavorOfCanToBeAdded.ToUpper() == "REGULAR" && IsFull("regular") == false)
            {
                _regular++;
            }
            else if (FlavorOfCanToBeAdded.ToUpper() == "ORANGE" && IsFull("orange") == false)
            {
                _orange++;
            }
            else if (FlavorOfCanToBeAdded.ToUpper() == "LEMON" && IsFull("lemon") == false)
            {
                _lemon++;
            }
            else
            {
                Console.WriteLine($"Could not add {FlavorOfCanToBeAdded} to SodaMachineRacks");
            }
        }

        public void AddCanOf(Flavor FlavorOfCanToBeAdded)
        {
            if (Enum.GetName(typeof(Flavor), FlavorOfCanToBeAdded) == "REGULAR" && IsFull("regular") == false)
            {
                _regular++;
            }
            else if (Enum.GetName(typeof(Flavor), FlavorOfCanToBeAdded) == "ORANGE" && IsFull("orange") == false)
            {
                _orange++;
            }
            else if (Enum.GetName(typeof(Flavor), FlavorOfCanToBeAdded) == "LEMON" && IsFull("lemon") == false)
            {
                _lemon++;
            }
            else
            {
                Console.WriteLine($"Could not add {FlavorOfCanToBeAdded} to SodaMachineRacks");
            }
        }

        public void RemoveCanOf(string FlavorOfCanToBeRemoved)
        {
            if (FlavorOfCanToBeRemoved.ToUpper() == "REGULAR" && IsEmpty("regular") == false)
            {
                _regular--;
            }
            else if (FlavorOfCanToBeRemoved.ToUpper() == "ORANGE" && IsEmpty("orange") == false)
            {
                _orange--;
            }
            else if (FlavorOfCanToBeRemoved.ToUpper() == "LEMON" && IsEmpty("lemon") == false)
            {
                _lemon--;
            }
            else
            {
                Console.WriteLine($"Could not remove {FlavorOfCanToBeRemoved} from SodaMachineRacks");
            }
        }

        public void RemoveCanOf(Flavor FlavorOfCanToBeRemoved)
        {
            if (Enum.GetName(typeof(Flavor), FlavorOfCanToBeRemoved) == "REGULAR" && IsEmpty("regular") == false)
            {
                _regular--;
            }
            else if (Enum.GetName(typeof(Flavor), FlavorOfCanToBeRemoved) == "ORANGE" && IsEmpty("orange") == false)
            {
                _orange--;
            }
            else if (Enum.GetName(typeof(Flavor), FlavorOfCanToBeRemoved) == "LEMON" && IsEmpty("lemon") == false)
            {
                _lemon--;
            }
            else
            {
                Console.WriteLine($"Could not remove {FlavorOfCanToBeRemoved} from SodaMachineRacks");
            }
        }

        public void FillTheCanRack()
        {
            _regular = 3;
            _orange = 3;
            _lemon = 3;
        }

        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            if (FlavorOfBinToBeEmptied.ToUpper() == "REGULAR")
            {
                _regular = 0;
            }
            if (FlavorOfBinToBeEmptied.ToUpper() == "ORANGE")
            {
                _orange = 0;
            }
            if (FlavorOfBinToBeEmptied.ToUpper() == "LEMON")
            {
                _lemon = 0;
            }
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            if (Enum.GetName(typeof(Flavor), FlavorOfBinToBeEmptied) == "REGULAR")
            {
                _regular = 0;
            }
            if (Enum.GetName(typeof(Flavor), FlavorOfBinToBeEmptied) == "ORANGE")
            {
                _orange = 0;
            }
            if (Enum.GetName(typeof(Flavor), FlavorOfBinToBeEmptied) == "LEMON")
            {
                _lemon = 0;
            }
        }

        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            if (FlavorOfBinToCheck.ToUpper() == "REGULAR" && _regular == 3)
            {
                return true;
            }
            else if (FlavorOfBinToCheck.ToUpper() == "ORANGE" && _orange == 3)
            {
                return true;
            }
            else if (FlavorOfBinToCheck.ToUpper() == "LEMON" && _lemon == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            if (Enum.GetName(typeof(Flavor), FlavorOfBinToCheck) == "REGULAR" && _regular == 3)
            {
                return true;
            }
            else if (Enum.GetName(typeof(Flavor), FlavorOfBinToCheck) == "ORANGE" && _orange == 3)
            {
                return true;
            }
            else if (Enum.GetName(typeof(Flavor), FlavorOfBinToCheck) == "LEMON" && _lemon == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            if (FlavorOfBinToCheck.ToUpper() == "REGULAR" && _regular == 0)
            {
                return true;
            }
            else if (FlavorOfBinToCheck.ToUpper() == "ORANGE" && _orange == 0)
            {
                return true;
            }
            else if (FlavorOfBinToCheck.ToUpper() == "LEMON" && _lemon == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            if (Enum.GetName(typeof(Flavor), FlavorOfBinToCheck) == "REGULAR" && _regular == 0)
            {
                return true;
            }
            else if (Enum.GetName(typeof(Flavor), FlavorOfBinToCheck) == "ORANGE" && _orange == 0)
            {
                return true;
            }
            else if (Enum.GetName(typeof(Flavor), FlavorOfBinToCheck) == "LEMON" && _lemon == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
