using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_lecture5_Classes
{
    public class Instructor
    {
        // Fields
        string LastName;
        string FirstName;
        string phone;
        // Constructor
        public Instructor(string lastName, string firstName, string phone)
        {
            LastName = lastName;
            FirstName = firstName; 
            this.phone = phone;
        }
        // property / access modifier - type of the field - name of the field ( UpperCase ) - No parentheses
        // get is used to READ the information, if you ONLY have a get - it's read only
        public string Lastname
        {
            get { return LastName; }
            // Getter and Setter / getter allows user to READ the Value - setter lets you WRTIE the value
            set { LastName = value; } // Value is the VALUE being assigned by the user

        }
        
    }
}
