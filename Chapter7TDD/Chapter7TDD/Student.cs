using System;

namespace Chapter7TDD
{
    public class Student
    {
        public char GetLetterGrade(int score)
        {
            char letterGrade = 'F';
            if (score == 90)
            {
                letterGrade = 'A';
            }
            return letterGrade;
        }
    }
}