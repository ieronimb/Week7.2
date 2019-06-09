using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupedbyGroupNumber
{
    public class Student
    {
        // Campuri
        private string firstName;
        private string lastName;
        private string groupNumber;

        // Constructor
        public Student(string firstName, string lastName, string groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.groupNumber = groupNumber;
        }

        // Proprietati
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
            
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }            
        }

        public string GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }           
        }
    }
}