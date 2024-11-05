using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class LinearSearch<T>
    {
        static int Search(T[] v, T x)
        {
            for (int i = 0; i < v.Length; i++)
                if (v[i]!.Equals(x)) 
                    return i;

            return -1;
        }
    }
}
