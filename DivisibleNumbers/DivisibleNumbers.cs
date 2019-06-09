using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleNumbers
{
    class DivisibleNumbers
    {
        /*Problem 6. Divisible by 7 and 3
        Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/
        // Using lambda expressions
        static void NumbersUsingLambda(int[] list)
        {
            var numbers = list.Where(x => (x % 7) == 0 && (x % 3) == 0);

            Console.WriteLine(">>>With Lambda expressions");
            Console.WriteLine("Numbers divisible by 7 and 3 at the same time are: ");

            foreach (var obj in numbers)
            {
                Console.WriteLine(obj);
            }      
        }

        // Using LINQ query
        static void NumbersUsingLINQ(int[] list)
        {
            var numbers =
                from number in list
                where number % 7 == 0 && number % 3 == 0
                select number;

            Console.WriteLine(">>>With LINQ query");
            Console.WriteLine("Numbers divisible by 7 and 3 at the same time are: ");

            foreach (var obj in numbers)
            {
                Console.WriteLine(obj);
            }
        }


        static void Main(string[] args)
        {
            int[] MyList = {21, 45, 441, 70, 15, 1, 2, 74 };

            NumbersUsingLambda(MyList);
            NumbersUsingLINQ(MyList);
            Console.ReadKey();
        }
    }
}
