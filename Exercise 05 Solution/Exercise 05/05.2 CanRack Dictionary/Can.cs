using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._2_CanRack_Dictionary
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
