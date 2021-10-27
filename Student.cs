using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods
{
    public class Student
    {
        public Student(string firstName, string lastName, int grade, int age, int debt, int paid)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
            Age = age;
            Debt = debt;
            Paid = paid;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
        public int Debt { get; set; }
        public int Paid { get; set; }
    }
}
