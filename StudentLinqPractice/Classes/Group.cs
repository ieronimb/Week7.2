using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinqPractice.Classes
{
    /* Create a class Group with properties GroupNumber and DepartmentName.*/
    public class Group
    {
        // Campuri
        private int groupNumber;
        private string departmentName;

        // Constructor
        public Group(int groupNumber, string departmentName)
        {
            this.groupNumber = groupNumber;
            this.departmentName = departmentName;
        }

        // Proprietati
        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }           
        }

        public string DepartmentName
        {
            get { return this.departmentName; }
            set { this.departmentName = value; }           
        }
    }
}
