using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class RecursiveBinarySearch<T> where T : IComparable<T>
    {
        static int Search(T[] v, T x, int left, int right)
        {
            int n = right - left + 1;
            if (n == 1)
                return -1;

            int middle = left + n / 2;
            if (x.Equals(v[middle]))
                return middle;

            if (x.CompareTo(v[middle]) < 0)
                return Search(v, x, left, middle - 1);

            return Search(v, x, middle + 1, right);
        }

        static int Search(T[] v, T x)
        {
            return Search(v, x, 0, v.Length - 1);
        }
    }
}
