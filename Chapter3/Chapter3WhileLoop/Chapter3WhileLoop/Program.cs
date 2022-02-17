using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user for a score
            Console.WriteLine("Enter Student score(-1 to terminate):");
            // store the score as a varable
            double score = double.Parse(Console.ReadLine());
            // start loop
            while(score>=0)
            {
               // check if score is 90 or higher
               if(score>=90)
                {
                    Console.WriteLine("Congratulations");
                }
               else
                {
                    Console.WriteLine("Thanks for using the system");
                }
                // prompt the user for a score
                Console.WriteLine("Enter student score(-1 to terminate):");
                score = double.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
