using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    class ActionDelegate
    {

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Action delegate");
            Action<int> printActionDel = new Action<int>(ConsolePrint);
            printActionDel(158);

            Console.WriteLine("Anonymous method with Action delegate");
            Action<int> anonymousActionDel = delegate (int i)
            {
                Console.WriteLine(i);
            };
            anonymousActionDel(1500);

            Console.WriteLine("Lambda expression with Action delegate");
            Action<int> lamdaActionDel = i => Console.WriteLine(i);

            lamdaActionDel(1879);

            Console.ReadKey();
        }
    }
}
