using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class LinqExamples
    {
        delegate bool IsTeenAger(Student stud);
        delegate bool FindStudent(Student std);

        class StudentExtension
        {
            public static Student[] Where(Student[] stdArray, FindStudent del)
            {
                int i = 0;
                Student[] result = new Student[10];
                foreach (Student std in stdArray)
                    if (del(std))
                    {
                        result[i] = std;
                        i++;
                    }

                return result;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("LINQ Query to Array");
            // Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };
            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;
            // Query execution
            foreach (var name in myLinqQuery)
                Console.WriteLine(name + " ");

            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  } ,
            };

            Student[] students = StudentExtension.Where(studentArray, delegate (Student std) {
                return std.Age > 12 && std.Age < 20;
            });

            // Use LINQ to find teenager students
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            // Use LINQ to find first student whose name is Bill 
            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

            // Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();

            Console.WriteLine("LINQ Query Syntax, example 1:");

            // string collection
            IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C#",
            "MVC Tutorials" ,
            "Java"
            };

            // LINQ Query Syntax
            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }


            Console.WriteLine("LINQ Query Syntax, example 2:");

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            Console.WriteLine("Teen age Students:");

            foreach (Student std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName);
            }

            Console.ReadKey();
        }      
        
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
