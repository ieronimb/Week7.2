using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class Program
    {
        /*Problem 17. Longest string
        Write a program to return the string with maximum length from an array of strings.
        Use LINQ.*/
        static void Main(string[] args)
        {
            var array = new string[] { "", "works", "course", "System", "Generic List"};
            string maxLength = array.OrderByDescending(x => x.Length).First();

            Console.WriteLine("The string with max length is: " + maxLength);
            Console.ReadKey();
        }
    }
}
