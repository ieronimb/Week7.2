using StringBuilderExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    class StringBuilderSubstring
    {
        /*Problem 1. StringBuilder.Substring
        Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has 
        the same functionality as Substring in the class String.*/

        static void Main(string[] args)
        {
            StringBuilder myString = new StringBuilder();
            myString.Append("Testing method extention");
            Console.WriteLine(myString.Substring(3, 9));            

            Console.ReadKey();
        }

    }
}
