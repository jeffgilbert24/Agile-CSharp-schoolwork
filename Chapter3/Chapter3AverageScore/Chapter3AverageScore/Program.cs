// This program will that the average of 10 students and display them numeric
using System;
using System.Linq;

namespace Chapter3AverageScore
{
    class Program
    {
        static void Main(string[] args)
        {
            // declares an array that can hold 10 int scores
            int[] scores = new int[10];
            // using a loop to prompt the user for input, one score at a time
            for(int count = 0; count < scores.Length; count++)
            {
                Console.WriteLine("Enter a score");
                scores[count] = int.Parse(Console.ReadLine());
            }
            // Displays the statistic
            Console.WriteLine("Average:{0}   ",scores.Average());
            Console.WriteLine("Highest:{0}   ",scores.Max());
            Console.WriteLine("Lowest: {0}   ",scores.Min());
            Console.ReadKey();
        }
    }
}
