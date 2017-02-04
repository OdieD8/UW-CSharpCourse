using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._4_Exceptions
{
    class Can
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
