using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupedbyGroupNumber
{
    class GroupedbyGroupNumber
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

            Console.WriteLine("Linq: Print students grouped by GroupNumber:");
            foreach (var obj in list)
            {
                Console.WriteLine($"First Name: { obj.FirstName}; Last Name: {obj.LastName}; GroupNumber: {obj.GroupNumber}.");
            }
        }

        /*Problem 19. Grouped by GroupName extensions
        Rewrite the previous using extension methods.*/
        public static void GroupByGrouNumberLambda(List<Student> list)
        {
            var students = list.GroupBy(x => x.GroupNumber).OrderBy(y => y.Key);

            Console.WriteLine("Linq: Print students grouped by GroupNumber: ");
            foreach (var obj in list)
            {
                Console.WriteLine($"First Name: { obj.FirstName}; Last Name: {obj.LastName}; GroupNumber: {obj.GroupNumber}.");
            }
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
               new Student("Popescu","Mihai","AN-006"),
               new Student("Mitrea","Ionut","FN-016"),
               new Student("Maitrei","Oana","AN-006"),
               new Student("Mihnea","Cornel","FN-016")
            };

            GroupByGrouNumberLinq(list);
            GroupByGrouNumberLambda(list);
            Console.ReadKey();
        }
    }
}
