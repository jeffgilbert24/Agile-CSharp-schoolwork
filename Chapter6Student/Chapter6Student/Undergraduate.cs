using System;

namespace Chapter6Student
{
   public class Undergraduate:Student
    {
        // constructor
        public Undergraduate(string studentId, string studentName,
            int studentScore)
            :base(studentId, studentName, studentScore)
        {
        }
        // method
        public string GetLetterGrade()
        {
            string letterGrade;
            if (StudentScore >= 94)
                letterGrade = "A";
            else if (StudentScore >= 90)
                letterGrade = "A-";
            else if (StudentScore >= 87)
                letterGrade = "B+";
            else if (StudentScore >= 84)
                letterGrade = "B";
            else if (StudentScore >= 80)
                letterGrade = "B-";
            else if (StudentScore >= 77)
                letterGrade = "C+";
            else if (StudentScore >= 74)
                letterGrade = "C";
            else if (StudentScore >= 70)
                letterGrade = "C-";
            else if (StudentScore >= 67)
                letterGrade = "D+";
            else if (StudentScore >= 64)
                letterGrade = "D";
            else if (StudentScore >= 60)
                letterGrade = "D-";
            else
                letterGrade = "F";
            return letterGrade;
        }
        public override string ToString()
        {
            string str;
            str = base.ToString() + string.Format("Letter grade: {0}",
                GetLetterGrade());
            return str;
        }
    }
}
