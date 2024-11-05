using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class SelectionSort<T> where T : IComparable<T>
    {
        static int GetMinIndex(T[] v, int left, int right)
        {
            int min_index = left;
            for (int i = left + 1; i <= right; i++)
                if (v[i].CompareTo(v[min_index]) < 0)
                    min_index = i;

            return min_index;
        }

        static void Sort(T[] v)
        {
            for (int i = 0; i < v.Length - 1; i++)
            {
                int min_index = GetMinIndex(v, i, v.Length - 1);
                (v[i], v[min_index]) = (v[min_index], v[i]);
            }
        }

        static void Print(T[] v)
        {
            foreach(T t in v)
                Console.WriteLine(t);
        }
    }
}
