using StudentLinqPractice.Class;
using StudentLinqPractice.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinqPractice
{

    class Program    {
        

        /* Problem 9. Student groups       
       Create a List<Student> with sample students.Select only the students that are from group number 2.*/       
        static void StudentsByGroupNumberLinq(List<Student> list)
        {
            var students = from st in list
                           where st.GroupNumber.GroupNumber == 2
                           orderby st.FirstName
                           select st;
            Console.WriteLine("Using Linq query: Students from group number 2 are: \n");
            foreach (var obj in students)
            {
                Console.Write($"First Name: {obj.FirstName}; Last name:  {obj.LastName}; \nFN: {obj.FN}; " +
                    $"\nTelephone: {obj.Telephone} \nEmail: {obj.Email} \nGroup: {obj.GroupNumber} \nMarks: {obj.Marks}");
            }
        }

        /*Problem 10. Student groups extensions
        Implement the previous using the same query expressed with extension methods.*/
        static void StudentsByGroupNumberLambda(List<Student> list)
        {
            var students = list.Where(x => (x.GroupNumber.GroupNumber == 2)).OrderBy(x => x.FirstName);

            Console.WriteLine("\nUsing Lambda: Students from group number 2 are: \n");
            foreach (var obj in students)
            {
                Console.Write($"First Name: {obj.FirstName}; Last name:  {obj.LastName}; \nFN: {obj.FN}; " +
                    $"\nTelephone: {obj.Telephone} \nEmail: {obj.Email} \nGroup: {obj.GroupNumber} \nMarks: {obj.Marks}");
            }
        }

       /*Problem 11. Extract students by email
        Extract all students that have email in abv.bg.
        Use string methods and LINQ.*/
        static void StudentsByEmail(List<Student> list)
        {
            var students = from st in list
                           where st.Email.EndsWith("abv.bg")
                           select st;
            Console.WriteLine("\nStudents with email abv.bg: \n");
            foreach (var obj in students)
            {
                Console.Write($"First Name: {obj.FirstName}; Last name:  {obj.LastName}; \nFN: {obj.FN}; " +
                    $"\nTelephone: {obj.Telephone} \nEmail: {obj.Email} \nGroup: {obj.GroupNumber} \nMarks: {obj.Marks}");
            }
        }

        /*Problem 12. Extract students by phone
        Extract all students with phones in Sofia.
        Use LINQ.*/
        static void StudentsPhoneSofia(List<Student> list)
        {
            var students = from st in list
                           where st.Telephone.StartsWith("075")
                           select st;

            Console.WriteLine("\nStudents with phones in Sofia: \n");
            foreach (var obj in students)
            {
                Console.Write($"First Name: {obj.FirstName}; Last name:  {obj.LastName}; \nFN: {obj.FN}; " +
                    $"\nTelephone: {obj.Telephone} \nEmail: {obj.Email} \nGroup: {obj.GroupNumber} \nMarks: {obj.Marks}");
            }
        }

        /*Problem 15. Extract marks
        Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).*/
        static void Students2006FN(List<Student> list)
        {
            var students = from st in list
                           where st.FN.EndsWith("06")
                           select st;

            Console.WriteLine("\nStudents marks enrolled in 2006: \n");
            foreach (var obj in students)
            {
                Console.Write($"First Name: {obj.FirstName}; Last name:  {obj.LastName}; \nFN: {obj.FN}; " +
                    $"\nTelephone: {obj.Telephone} \nEmail: {obj.Email} \nGroup: {obj.GroupNumber} \nMarks: {obj.Marks}");
            }
        }

        /*Problem 16. Groups
        Create a class Group with properties GroupNumber and DepartmentName.
        Introduce a property GroupNumber in the Student class.
        Extract all students from "Mathematics" department.
        Use the Join operator.*/

        static void StudentsFromMathematicsDepartment(List<Student> list)
        {
            var students = from st in list
                           where st.GroupNumber.DepartmentName == "Mathematics"
                           select st;          
           Console.WriteLine("\nStudents from Mathematics department: \n");
            foreach (var obj in students)
            {
                Console.Write($"First Name: {obj.FirstName}; Last name:  {obj.LastName}; \nFN: {obj.FN}; " +
                    $"\nTelephone: {obj.Telephone} \nEmail: {obj.Email} \nGroup: {obj.GroupNumber} \nMarks: {obj.Marks}");
            }
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {                
                
            };

            StudentsByGroupNumberLinq(list);
            StudentsByGroupNumberLambda(list);
            StudentsByEmail(list);
            StudentsPhoneSofia(list);
            Students2006FN(list);
            StudentsFromMathematicsDepartment(list);
            Console.ReadKey();
        }
    }
}
