using System;
namespace Chapter5Employee
{
    class Employee
    {
        // fields
        private string employeeId;
        private string employeeName;
        private DateTime datePromoted;
        // properties
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public DateTime DatePromoted
        {
            get { return datePromoted; }
            set { datePromoted = value; }
        }
        // constructor
        public Employee(string employeeId, string employeeName,
            DateTime datePromoted)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.datePromoted = datePromoted;                
        }
        // methods
        public string Promote()
        {
            string message = "";
            if (DatePromoted.AddMonths(3) < DateTime.Now)
                message = "It's time for promotion";
            return message;
        }
        public override string ToString()
        {
            string str;
            str = string.Format("{0, -10}{0, -10}{1, -10}{2, 20}",
               EmployeeId, EmployeeName, Promote());
            return str;
                {

            }
        }

    }
}
