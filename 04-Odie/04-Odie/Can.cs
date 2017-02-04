//Exercise 04
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Odie
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
}
