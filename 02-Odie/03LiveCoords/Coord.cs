using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LiveCoords
{
    class Coord // Cartesian implementation
    {
        private int _x;
        private int _y;

        public Coord(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Coord(double radius, double theta)
        {
            // _x = 
        }

        public Coord()
        {
            _x = 0;
            _y = 0;
        }


    }
}
