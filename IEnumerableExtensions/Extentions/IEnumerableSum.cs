using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class IEnumerableSum
    {
      
        public static int Sum<T>(this IEnumerable<int> list)
        {
            if (list.Count() ==0)
            {
                throw new NullReferenceException("The list is empty");
            }
            else
            {
                int sum = 0;
                foreach (int element in list)
                {
                    sum += element;
                }
                return sum;
            }
        }

    }
}
