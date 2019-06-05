using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    public delegate TResult Func<in T, out TResult>(T arg); //One input parameter and oen outptu parameter -> https://www.tutorialsteacher.com/Content/images/csharp/func-delegate.png
    public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);//Func delegate with two input parameters and one out parameters -> https://www.tutorialsteacher.com/Content/images/csharp/func-delegate2.png

    class FuncDelegate
    {
        static int Suma(int x, int y)
        {
            return x + y;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Func Delegate example:");
            Func<int, int, int> add = Suma;
            int result = add(10, 10);
            Console.WriteLine($"Sum of 10 + 10: {result}");


            Console.WriteLine("Func with Anonymous Method:");
            Func<int> anonGetRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);                 
            };

            Console.WriteLine("Func with Lambda Expression (random number from 1 to 100)");
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber());
            Func<int, int, int> Sum = (x, y) => x + y;            
            Console.Write("And sum of 10 and 20: " + Sum(10, 20));

            Console.ReadKey();
        }

       
    }
}
