using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3Ex4Ex5.Class;

namespace Ex3Ex4Ex5.Methods
{
    public class StudentLinqMethods
    {
        /*Problem 3. First before last
        Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
        Use LINQ query operators.*/

        public static void FirstNamBeforeLastName(Student[] list)
        {
            var students = from st in list
                           where st.FirstName.CompareTo(st.LastName) > 0
                           select st;
            foreach (var obj in students)
            {
                Console.WriteLine("First Name{0}; Last Name{1}", obj.FirstName, obj.LastName);
            }
        }

        /*Problem 4. Age range
        Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/
        public static void StudentsWithinAge(Student [] list)
        {
            var students = from st in list
                           where (st.Age >= 18 && st.Age <= 24)
                           select st;
            foreach (var obj in students)
            {
                Console.WriteLine("First Name{0}; Last Name{1}; Age: {2}", obj.FirstName, obj.LastName, obj.Age);
            }
        }
        /*Problem 5. Order students
        Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
        Rewrite the same with LINQ.*/

        static void SortUsingLambda(Student[] list)
        {
            var students = list.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.LastName);

            foreach (var obj in students)
            {
                Console.WriteLine("First Name{0}; Last Name{1}", obj.FirstName, obj.LastName);
            }
        }
        
        static void SortUsingLINQ(Student[] list)
        {
            var students = from st in list
                           orderby st.FirstName descending, st.LastName descending
                          select st;

            foreach (var obj in students)
            {
                Console.WriteLine("First Name{0}; Last Name{1}", obj.FirstName, obj.LastName);
            }
        }
    }
}
