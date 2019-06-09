using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupedbyGroupNumber
{
    class Program
    {
        /*Problem 18. Grouped by GroupNumber
         Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
         Use LINQ.*/
        // Extract all students grouped by GroupName, using LINQ
        static void GroupByGrouNumberLinq(List<Student> list)
        {
            var students = from st in list
                           group st by st.GroupNumber into newGroup
                           orderby newGroup.Key
                           select newGroup;

            Console.WriteLine("Print students grouped by GroupName: (Using LINQ query) ");
            foreach (var element in list)
            {
                Console.WriteLine("Full name: {0} {1} \nGroup name: {2}", element.FirstName, element.LastName, element.GroupNumber);
            }
        }

        /*Problem 19. Grouped by GroupName extensions
        Rewrite the previous using extension methods.*/
        public static void GroupByGrouNumberLambda(List<Student> list)
        {
            var students = list.GroupBy(x => x.GroupNumber).OrderBy(y => y.Key);

            Console.WriteLine("Print students grouped by GroupName: (Using Lambda expression) ");
            foreach (var element in list)
            {
                Console.WriteLine("Full name: {0} {1} \nGroup name: {2}", element.FirstName, element.LastName, element.GroupNumber);
            }
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
               
            };

            GroupByGrouNumberLinq(list);
            GroupByGrouNumberLambda(list);
        }
    }
}
