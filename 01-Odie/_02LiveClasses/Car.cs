using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LiveClasses // an identifier is not allowed to start with a digit
{
    class Car // contain fields, methods
        // these things have access specifiers: public and private (default)
    {
        // state of the  car, data, nouns
        private int _wheelCount = 4; //field wheelCount, "instance variable"
        private int _milesDriven = 0;
        // functionality of the car, methods, verbs, something to "do"

        public Car() // constructor, ctor, initialization, parameterless
        {
            _wheelCount = 5;
        }

        public Car(int initialOilLevel)
        {
            OilLevel = initialOilLevel;
        }

        public int Drive(int distance)
        {
            if (_milesDriven > 1000000)
            {
                Debug.WriteLine("This is an old car about to expire");
            }
            else
            {
                Debug.WriteLine("Car still has life left");
            }
            _milesDriven += distance;
            return distance;
        }

        public int Drive() // overload of Drive
        {
            Drive(100);
            return 100;
        }

        // property is halfway between method and field
        public int Odometer
        {
            get { // rhs
                return _milesDriven;
            }
            set // lhs
            {
                if (value > _milesDriven)
                {
                    _milesDriven = value;
                }
            }
        }

        public int OilLevel // auto-implemented property
        {
            get; set;
        }

        private int _vin = 123;
        public int VIN // transparent property
        {
            get { return _vin; }
            set { _vin = value; }
        }
    }
}
