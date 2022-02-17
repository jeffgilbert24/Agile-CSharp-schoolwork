using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4ReturnValuePlus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two int variable with values
            int a = 3;
            int b = 5;
            // call the plus() method and store the return value in total
            int total = plus(a, b);
            // display the result
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, total);
            Console.ReadKey();
        }
        // plus () method
        static int plus(int x, int y)
        {
            int sum;
            sum = x + y;
            return sum;
        }
    }
}
