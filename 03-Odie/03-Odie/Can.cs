//Exercise 03
//Odie de Moura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Odie
{
    public enum Flavor { REGULAR, ORANGE, LEMON };

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
