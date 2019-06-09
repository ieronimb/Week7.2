using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions.Extentions
{
    public static class IEnumerableAverage
    {
        public static int Average<T>(this IEnumerable<int> list)
        {
            if (list.Count() == 0)
            {
                throw new NullReferenceException("The list is empty");
            }
            else
            {
                int average = 0;
                foreach (int element in list)
                {
                    average += element;
                }
                return average / list.Count();
            }
        }
    }
}
