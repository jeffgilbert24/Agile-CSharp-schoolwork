// This program will divide two numbers
using System;

namespace Chapter4DivideinsideMainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // create three int variables
            int a = 11;
            int b = 5;
            int remainder;
            // call the Divide() method and store the return value in quotient
            int quotient = Divide(a, b, out remainder);
            // display the results
            Console.WriteLine("{0} divided by {1} is {2} with remainder of {3}", a, b, quotient, remainder);
            Console.ReadKey();
        }
        // Divide method
        static int Divide(int x, int y, out int r)
        {
            int q;
            q = x / y;
            r = x % y;
            return q;
        }
    }
}
