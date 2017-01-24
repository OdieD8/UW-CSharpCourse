using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LiveEnum
{
    class Program
    {
        enum color { red = 10, RED = 10, orange, yellow, cyan }
        enum fruit { banana, apple, orange }

        static void Main(string[] args)
        {
            int i;
            color favorite = color.cyan;

            // int, float, double (types)
            // colors
            // red is an enumeral
            //const int red = 0; // red is a constant
            //const int orange = 1; 
            //const int yellow = 2;
            //red = yellow; // cannot do

            // fruit
            //const int banana = 3;
            //const int apple = 4;

            Console.Write("Favorite Color: ");
            string input = Console.ReadLine().ToLower();

            //favorite = (color)Enum.Parse(typeof(color), input);

            if (Enum.TryParse<color>(input, out favorite))
            {
                Console.WriteLine("What you typed in was legal");
            }
            else
            {
                Console.WriteLine("{0} is not a color", input);
            }

            Console.WriteLine("Your favorite color is {0}", favorite);
        }
    }
}
