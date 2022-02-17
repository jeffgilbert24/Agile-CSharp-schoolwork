using System;

namespace Chapter3IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user for a score
            Console.WriteLine("Enter Student score:");
            //store the score in a varable
            double score = double.Parse(Console.ReadLine());
            // check if score is a 90 of higher
            if (score >= 90)
            {
                Console.WriteLine("Congratulations!");
            }
            else
                Console.WriteLine("Thanks for using the system");
            Console.ReadKey();
        }
    }
}
