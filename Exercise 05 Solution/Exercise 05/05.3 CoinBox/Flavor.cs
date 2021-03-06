﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._3_CoinBox
{
    enum Flavor { REGULAR, ORANGE, LEMON }
    static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        static FlavorOps()
        {
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                Flavor flavorEnumeral = ToFlavor(flavorName);
                _allFlavors.Add(flavorEnumeral);
            }
        }

        // method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            FlavorName = FlavorName.ToUpper();
            Flavor result = Flavor.REGULAR;
            if (Enum.IsDefined(typeof(Flavor), FlavorName))
            {
                result = (Flavor)Enum.Parse(typeof(Flavor), FlavorName);
            }
            else
            {
                // what happens if the string won't convert to
                // a Flavor enumeral?
            }
            return result;
        }

        // property to return a List<Flavor> of all of the Flavors
        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
            }
        }

    }
}