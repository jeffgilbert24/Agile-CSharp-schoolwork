using System;

namespace Programming_Challenge2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for the radius of the pizza
            Console.WriteLine("What is the radius of the pizza in inches?");
            //Store the value in a variable
            double radius = double.Parse(Console.ReadLine());
            //Calulate the area of the pizza
            double area = 3.14 * radius * radius;
            // Calulate the number of slices, each slice should be 15 inches
            double numberOfSlices = area / 15;
            // display the results to the user
            Console.WriteLine("The pizza can be cut into {0} slices", numberOfSlices);
            Console.ReadKey();
            
        }
    }
}
