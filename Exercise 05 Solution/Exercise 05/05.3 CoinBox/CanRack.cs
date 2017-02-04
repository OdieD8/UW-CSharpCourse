using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _05._3_CoinBox
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number in an array indexed
    //  by the Flavor enumeration (e.g., rack[Flavor.ORANGE] == 1 means 
    //  that there is one can of orange soda in the rack).
    class CanRack
    {
        private Dictionary<Flavor,int> rack = null;
        public const int EMPTYBIN = 0; 
        public const int BINSIZE = 3;

        private const int DUMMYARGUMENT = 0;
        
        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
            rack = new Dictionary<Flavor,int>();
            FillTheCanRack();
        }

        //  This method adds a can of the specified flavor to the rack.  
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine("*** Failed attempt to add a can of {0} to a full rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
            else
            {
                Debug.WriteLine("adding a can of {0} flavored soda to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
                // convert the string Flavor into the Flavor value
                Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfCanToBeAdded);
                rack[flavorEnumeral]++;
            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("*** Failed attempt to remove a can of {0} from an empty rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
            else
            {
                Debug.WriteLine("removing a can of {0} flavored soda to the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                // convert the string Flavor into the appropriate Flavor value
                Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfCanToBeRemoved);
                rack[flavorEnumeral]--;
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                rack[aFlavor] = BINSIZE;
            }
        }

        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToBeEmptied);
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied);
            rack[flavorEnumeral] = EMPTYBIN;
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString());
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToBeChecked)
        {
            FlavorOfBinToBeChecked = FlavorOfBinToBeChecked.ToUpper();
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            // convert the string Flavor into the appropriate int value
            Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToBeChecked);
            return rack[flavorEnumeral] == BINSIZE;
        }

        public Boolean IsFull(Flavor CanBinToCheck)
        {
            return IsFull(CanBinToCheck.ToString());
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToBeChecked)
        {
            FlavorOfBinToBeChecked = FlavorOfBinToBeChecked.ToUpper();
            Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            // convert the string Flavor into the appropriate int value
            Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToBeChecked);
            return rack[flavorEnumeral] == EMPTYBIN;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToBeChecked)
        {
            return IsEmpty(FlavorOfBinToBeChecked.ToString());
        }


        // write out the contents of rack array. For example, one flavor per line with the flavor name and
        // the number of cans of soda of that flavor. In a real system, this function would probably be in a 
        // separate class, and the CanRack would export this information as strings. We’re doing it this way
        // for the sake of the simplicity of the exercise.
        public void DisplayCanRack()
        {
            Console.WriteLine(".NET C# Vending Machine contents");
            Console.WriteLine("________________________________");
            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                Console.WriteLine("{0}\t{1}", aFlavor, rack[aFlavor]);
            }
            Console.WriteLine("________________________________");
        }

    } //end Can_Rack

}
