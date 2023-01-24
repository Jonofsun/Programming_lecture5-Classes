using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_lecture5_Classes
{
    public class Student
    {
        //Fields
        public string FirstName;
        public string LastName;
        public double GradeCSI;
        public double GradeGenEd;

        //Constructor
        //Access modifer - ClassName - Parentheses
        // default constructor ()

        // Constuctors allow / restricts what is needed to create an object
        public Student(string firstName, string lastName, double gradeCSI, double gradeGenED)
        {
            FirstName = firstName;
            LastName = lastName;
            GradeCSI = gradeCSI;
            GradeGenEd = gradeGenED;

        }
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            GradeCSI = -1;
            GradeGenEd = -1;
        }

        //Properties
        //Methods


    }
}
