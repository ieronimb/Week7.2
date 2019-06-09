using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions.Extentions
{
    public static class IEnumerableMin
    {
        public static int Min<T>(this IEnumerable<int> list)
        {
            if (list.Count() == 0)
            {
                throw new NullReferenceException("The list is empty");
            }
            else
            {
                int min = list.First();
                foreach (int element in list)
                {
                    if (min > element)
                    {
                        min = element;
                    }
                }
                return min;
            }
        }
    }
}
