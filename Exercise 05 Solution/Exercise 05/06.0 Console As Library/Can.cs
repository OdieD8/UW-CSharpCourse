using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    public class Can
    {

        public readonly Flavor TheFlavor = Flavor.REGULAR;

        public Can()
        {
        }

        public Can(Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }


    }
}
