using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _02_Odie
{
    class SodaMachineRack
    {
        private int _regular;
        private int _orange;
        private int _lemon;

        public SodaMachineRack()
        {
            Debug.WriteLine("New SodaMachineRacks object utilized");
            _regular = 3;
            _orange = 3;
            _lemon = 3;
        }

        public void AddCanOf(string FlavorOfCanToBeAdded)
        {
            Debug.WriteLine("AddCanOf Accessed");
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

        public void RemoveCanOf(string FlavorOfCanToBeRemoved)
        {
            Debug.WriteLine("RemoveCanOf Accessed");
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

        public void FillTheCanRack()
        {
            Debug.WriteLine("FillTheCanRack Accessed");
            _regular = 3;
            _orange = 3;
            _lemon = 3;
        }

        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            Debug.WriteLine("EmptyCanRackOf Accessed");
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

        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("IsFull checked");
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

        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("IsEmpty checkd");
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
    }
}
