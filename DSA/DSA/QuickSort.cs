using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class QuickSort<T> where T : IComparable<T>
    {
        static int Partition(T[] v, int left, int right)
        {
            int p = left;
            T pivot = v[right];

            for (int now = left; now < right; now++)
            {
                if (v[now].CompareTo(pivot) < 0)
                {
                    (v[p], v[now]) = (v[now], v[p]);
                    p++;
                }
            }
            
            (v[p], v[right]) = (v[right], v[p]);
            return p;
        }

        static void Sort(T[] v, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(v, left, right);
                Sort(v, left, p - 1);
                Sort(v, p + 1, right);
            }
        }

        static void Sort(T[] v) => Sort(v, 0, v.Length - 1);

        static void Print(T[] v)
        {
            foreach(T t in v) 
                Console.WriteLine(t);
        }
    }
}
