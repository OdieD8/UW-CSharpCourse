using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LiveClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // NOT a field, this is a variable
            x = 3;
            Car pinto; // pinto is a variable
            pinto = new Car(); // default constructor
            int milesDriven = pinto.Drive();
            Console.WriteLine("I Drove " + milesDriven);
            pinto.Drive();
            pinto.Drive();
            pinto.Drive(25);
            pinto.Drive(10);
            Car maverick = new Car(); // maverick is a reference variable
            maverick.Drive(13);
            maverick.Drive(16);

            Debug.WriteLine("This goes to the Debug Window");

            Console.WriteLine("Maverick drove " + maverick.Odometer);

            int currentMiles = pinto.Odometer; // rhs ::: get
            pinto.Odometer = 4;

            Console.WriteLine("Current miles " + currentMiles);
            Console.WriteLine("Pinto odometer " + pinto.Odometer);
            //Console.WriteLine("The maverick has been driven " + maverick.ReportTotalMilesDriven() + " miles" );

            pinto.OilLevel = 10; // set
            Console.WriteLine("Oil level is: " + pinto.OilLevel); // get

            maverick = pinto; // the two cars are the same - pointing to the same reference pinto is using (same space in memory)

            pinto = null; // breaks connection to reference of object
        }
    }
}
