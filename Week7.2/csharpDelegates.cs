using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7._2
{
    class CsharpDelegates
    {   //Delegate example
        public delegate void Print(int value);        

        static void Main(string[] args)

        {
            //PrintNumber
            Print newDel = new Print(PrintNumber);
            newDel(2500);
            newDel(1784);


            //PrintMoney
            newDel = PrintMoney;
            newDel(8796);
            newDel(555);

            //Invoking a delegate
            newDel = PrintNumber;
            newDel.Invoke(8793);
            newDel(2345);

            //Delegate as a Parameter
            PrintHelper(PrintNumber, 25800);
            PrintHelper(PrintMoney, 8795);

            //Multicast delegate

            //Remove existing function from a delegate object
            newDel -= PrintHexadecimal;
            newDel(47894);

            //Adding a function to delegate object
            newDel += PrintHexadecimal;
            newDel(58792);


            Console.ReadKey();
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
        //Delegate as a Parameter
        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }
        //Multicast delegate
        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
