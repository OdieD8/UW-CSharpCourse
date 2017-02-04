using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06LiveExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 0;
                int y = 100;

                Console.WriteLine(y / x);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Something very specific went wrong: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something specific went wrong: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Close the db"); // will always run
            }

            X anX = new X();

            try
            {
                anX.method();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw; // re-raising or re-throwing
            }
        }

        class X
        {
            public void method()
            {
                Console.WriteLine("in method before");
                throw new Exception("My Exception");
                Console.WriteLine("in method after"); // never gets to this code because there is an exception before
            }

            public void otherMethod()
            {
                throw new MyCustomeException();
            }

            public void otherMethod2()
            {
                throw new MyCustomeException("Extra special expection");
            }

        }

        class MyCustomeException : Exception
        {
            public MyCustomeException() : base("myMessage") { }

            public MyCustomeException()
        }
    }
}
