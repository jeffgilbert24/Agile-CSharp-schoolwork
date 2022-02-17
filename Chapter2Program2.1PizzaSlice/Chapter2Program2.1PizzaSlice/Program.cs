using System;

namespace Chapter2Program2._1PizzaSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            // defines Pi
            double x = 3.14;
            // defines minimun pizza slice size
            double SliceSize = 15;
            // prumpt user for size of pizza
            Console.WriteLine("What is the radius of the pizza?");
            //get the number from the user and save as variable 
            double y = int.Parse (Console.ReadLine());
            // calculate the area of the pizza
            double PizzaSize = x * (y * y);
            // determine number of size 15in slices
            double slice = PizzaSize / SliceSize;
            // display to user
            Console.WriteLine("You will have get these slices from a pizza this size" + slice);
            // pause the screen by waiting for key stroke
            Console.ReadKey();

            
        }
    }
}
