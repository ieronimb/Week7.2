using IEnumerableExtensions.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    /*Problem 2. IEnumerable extensions
    Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.*/
    class IEnumerableExamples
    {
        static void Main(string[] args)
        {
            IEnumerable<int> MyList = new int[] { 5, 6, 3, 8, 9, 100, 4, -3, 1, 230};

            Console.WriteLine($"The sum is {MyList.Sum<int>()}; The product is {MyList.Product<int>()}; " +
                              $"The min is {MyList.Min<int>()}; The max is {MyList.Max<int>()}; the average is {MyList.Average<int>()} ");            
            Console.ReadKey();
        }
    }
}

