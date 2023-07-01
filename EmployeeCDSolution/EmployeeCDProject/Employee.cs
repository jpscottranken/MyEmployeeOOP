using System;

namespace EmployeeCDProject
{
    public class Employee
    {
        //  Instance Variables
        //private int     _id;
        //private string  _firstName;
        //private string  _lastName;
        //private string  _department;
        //private decimal _salary;

        //  Default Constructor
        //  This will set the
        //  instance variables to
        //  the following values:
        //
        //  Id          -   0
        //  FirstName   -   Empty String
        //  LastName    -   Empty String
        //  Department  -   Empty String
        //  Salary      -   0.00M
        public Employee() { }

        //  Full-Arg Constructror
        public Employee(int id, 
                        string firstName,
                        string lastName,
                        string department,
                        decimal salary) 
        { 
            Id         = id;
            FirstName  = firstName;
            LastName   = lastName;
            Department = department;
            Salary     = salary;
        }

        //  Auto-Implemented Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return "ID:      " + Id.ToString() + "\r\n" +
                "First Name: " + FirstName + "\r\n"     +
                "Last  Name: " + LastName + "\r\n"      +
                "Department: " + Department + "\r\n"    +
                "Salary:     " + Salary.ToString("c") + "\r\n\r\n";
        }
    }
}
