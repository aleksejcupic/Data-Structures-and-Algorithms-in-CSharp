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
            int median;

            while (left <= right)
            {
                median = (left + right) / 2;
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

        static int SearchRecursive(T[] v, T x, int low, int high)
        {
            if (low > high) return -1;

            int median = (low + high) / 2;
            if (v[median].CompareTo(x) < 0)
                return SearchRecursive(v, x, median + 1, high);
            else if (v[median].CompareTo(x) > 0)
                return SearchRecursive(v, x, low, median - 1);
            else
                return median;
        }
    }
}
