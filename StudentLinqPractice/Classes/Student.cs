using StudentLinqPractice.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinqPractice.Class
{
    /* Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks(a List), GroupNumber.*/
    public class Student
    {
        // Campuri
        private string firstName;
        private string lastName;
        private string fn;
        private string telephone;
        private string email;
        private readonly List<int> marks;
        private Group groupNumber;

        // Constructor
        public Student(string firstName, string lastName, string fn, string telephone, string email, List<int> marks, Group groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fn = fn;
            this.telephone = telephone;
            this.email = email;
            this.marks = marks;
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

        public string FN
        {
            get { return this.fn; }
            set { this.fn = value; }            
        }

        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }            
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
            
        }

        public List<int> Marks
        {
            get { return this.marks; }
        }

        public Group GroupNumber
        {
            get { return this.groupNumber; }
            set {this.groupNumber = value;}
        }
    }
}
