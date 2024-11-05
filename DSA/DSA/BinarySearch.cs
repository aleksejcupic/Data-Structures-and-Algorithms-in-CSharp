using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class BinarySearch<T> where T : IComparable<T>
    {
        static int Search(T[] v, T x)
        {
            int left = 0;
            int right = v.Length - 1;

            while (left <= right)
            {
                int median = (left + right) / 2;
                T item = v[median];

                var comparison = x.CompareTo(item);
                if (comparison == 0)
                    return median;
                else if (comparison < 0)
                    right = median - 1;
                else
                    left = median + 1;
            }
            return -1;
        }
    }
}
