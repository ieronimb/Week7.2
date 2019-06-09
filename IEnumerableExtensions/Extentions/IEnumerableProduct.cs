using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions.Extentions
{
    public static class IEnumerableProduct
    {
        public static int Product<T>(this IEnumerable<int> list)
        {
            if (list.Count() == 0)
            {
                throw new NullReferenceException("The list is empty");
            }
            else
            {
                int product = 0;
                foreach (int element in list)
                {
                    product *= element;
                }
                return product;
            }
        }
    }
}
