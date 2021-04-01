using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal TuitionFees { get; set; }
        public Student(string aFirstName, string aLastName, DateTime aDateOfBirth, decimal aTuitionFees)
        {
            FirstName = aFirstName;
            LastName = aLastName;
            DateOfBirth = aDateOfBirth;
            TuitionFees = aTuitionFees;
        }
        public Student()
        {

        }
    }
}
