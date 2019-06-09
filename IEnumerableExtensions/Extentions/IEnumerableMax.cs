using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions.Extentions
{
    public static class IEnumerableMax
    {
        public static int MAx<T>(this IEnumerable<int> list)
        {
            if (list.Count() == 0)
            {
                throw new NullReferenceException("The list is empty");
            }
            else
            {
                int max = list.First();
                foreach (int element in list)
                {
                    if (max < element)
                    {
                        max = element;
                    }                    
                }
                return max;
            }
        }
    }
}
