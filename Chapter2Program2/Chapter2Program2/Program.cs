using System;

namespace Chapter2Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            // use variables to hold values
            int numberOfCandiesInBag = 50;
            int servingsPerBag = 25;
            int caloriesPerServing = 100;
            // find out how many candies per serving
            double candiesPerServing =
                numberOfCandiesInBag / servingsPerBag;
            // find out how many calories per candy
            double caloriesPerCandy = 
                caloriesPerServing / caloriesPerServing;
            // prompt user for number of candies he or she ate
            Console.WriteLine("How many candies did you eat?");
            // get the number from user and store it in a variable
            int candiesAte = int.Parse(Console.ReadLine());
            // calculate how many calories consumed
            double caloriesConsumed = candiesAte * caloriesPerCandy;
            // display to user
            Console.WriteLine("You have consumed {0} calories",
                caloriesConsumed);
            // pause the screen by waiting for user input
            Console.ReadKey();

        }
    }
}
