// This program will display scores and grades of students
using System;
using System.Linq;

namespace CHapter3ClassStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            //creat an int array that can hold 10 students scores
            int[] scores = new int[10];
            // using a loop to prompt user for score, one at a time
            for(int count = 0; count < scores.Length; count++)
            {
                Console.WriteLine("Enter a score;");
                scores[count] = int.Parse(Console.ReadLine());
            }
            // variables to hold number of A's,B's,C's,D's and F's
            int numberOfA = 0;
            int numberOfB = 0;
            int numberOfC = 0;
            int numberOfD = 0;
            int numberOfF = 0;
            // using a loop to check each score to find letter grade
            for(int count = 0; count< scores.Length; count++)
            {
                if (scores[count] >= 90)
                    numberOfA++;
                else if (scores[count] >= 80)
                    numberOfB++;
                else if (scores[count] >= 70)
                    numberOfC++;
                else if (scores[count] >= 60)
                    numberOfD++;
                else 
                    numberOfF++;
            }
            // Display the results
            Console.WriteLine("Number of As: {0}", numberOfA);
            Console.WriteLine("Number of Bs: {0}", numberOfB);
            Console.WriteLine("Number of Cs: {0}", numberOfC);
            Console.WriteLine("Number of Ds: {0}", numberOfD);
            Console.WriteLine("Number of Fs: {0}", numberOfF);
            Console.ReadKey();
        }
    }
}
