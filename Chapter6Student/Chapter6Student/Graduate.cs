

namespace Chapter6Student
{
    public class Graduate:Student
    {
        // constructor
        public Graduate(string studentId, string studentName, int studentScore)
            :base(studentId, studentName, studentScore)
        {
        }
        // methods
        public string GetLetterGrade()
        {
            string letterGrade;
            if (StudentScore >= 90)
                letterGrade = "A";
            else if (StudentScore >= 80)
                letterGrade = "B";
            else if (StudentScore >= 70)
                letterGrade = "C";
            else if (StudentScore >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";
            return letterGrade;      
        
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
