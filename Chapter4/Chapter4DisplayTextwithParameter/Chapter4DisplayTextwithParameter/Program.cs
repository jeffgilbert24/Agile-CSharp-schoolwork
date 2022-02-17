using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4DisplayTextwithParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the DisplayText method and passing a test.
            DisplayText("Agile is more fun.");
            Console.ReadKey();
        }
        // DisplayText method
        static void DisplayText(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.ReadKey();
        }
    }
}
