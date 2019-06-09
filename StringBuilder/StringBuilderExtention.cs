using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtension
{
    public static class SubstringExt
    {
       
        public static StringBuilder Substring(this StringBuilder sb, int Index, int Length)
        {
            StringBuilder Current = new StringBuilder();

            for (int i = Index; i <Index + Length; i++)
            {
                Current.Append(sb[i]);
            }
            return Current;
        }
    }
}
