using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegate
{
    class PredicateDelegates
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Predicate Delegates:");
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("TEST");
            Console.WriteLine(result);

            Console.WriteLine("Predicate delegate with anonymous method:");
            Predicate<string> AnonymousisUpper = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool anonymousResult = AnonymousisUpper("Anonymous");
            Console.WriteLine(anonymousResult);

            Console.WriteLine("Predicate delegate with lambda expression:");
            Predicate<string> LambdaisUpper = s => s.Equals(s.ToUpper());
            bool lambdaResult = LambdaisUpper("LAMBDA");
            Console.WriteLine(lambdaResult);

            Console.ReadKey();
        }
    }
}
