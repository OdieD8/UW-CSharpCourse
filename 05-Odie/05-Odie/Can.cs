//Exercise 05
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Odie
{
    public enum Flavor { REGULAR = 0, ORANGE = 1, LEMON = 2 };

    class Can
    {
        public readonly Flavor TheFlavor = Flavor.REGULAR;

        public Can()
        {

        }

        public Can (Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }
    }

    public static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        static FlavorOps() { }

        public static Flavor ToFlavor(string FlavorName)
        {
            FlavorName = FlavorName.ToUpper();
            if (Enum.IsDefined(typeof(Flavor), FlavorName))
            {
                Flavor flavor = (Flavor)Enum.Parse(typeof(Flavor), FlavorName);
                return flavor;
            }
            else
            {
                throw new Exception($"Flavor not recognized: {FlavorName}");
            }
        }

        public static List<Flavor> AllFlavors()
        {
            _allFlavors = Enum.GetValues(typeof(Flavor)).Cast<Flavor>().ToList();
            return _allFlavors;
        }
    }
}
