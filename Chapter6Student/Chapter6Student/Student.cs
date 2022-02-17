﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Student
{
    public class Student
    {
        // fields
        private string studentId;
        private string studentName;
        private int studentScore;
        // properties
        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int StudentScore
        {
            get { return studentScore; }
            set { studentScore = value; }
        }
        public Student(string studentId, string studentName, int studentScore)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentScore = studentScore;
        }
        public override string ToString()
        {
            string str;
            str = string.Format("Name: {0} SCore: {1}", StudentName, StudentScore);
            return str;
        }
    }
}
