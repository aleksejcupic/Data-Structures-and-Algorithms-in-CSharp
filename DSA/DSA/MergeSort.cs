using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class MergeSort<T> where T : IComparable<T>
    {
        static void Merge(T[] v, int left1, int right1, int left2, int right2)
        {
            int n1 = right1 - left1 + 1;
            int n2 = right2 - left2 + 1;

            T[] v1 = new T[n1];
            T[] v2 = new T[n2];

            for (int i = 0; i < n1; i++)
                v1[i] = v[left1 + i];

            for (int i = 0; i < n2; i++)
                v2[i] = v[left2 + i];

            int index1 = 0;
            int index2 = 0;
            int index = left1;

            while (true)
            {
                bool empty1 = index1 == n1;
                bool empty2 = index2 == n2;

                if (empty1 && empty2)
                    break;

                if (empty2 || (!empty1 && v1[index1].CompareTo(v2[index2]) < 0))
                {
                    v[index] = v1[index1];
                    index1++;
                }
                else
                {
                    v[index] = v2[index2];
                }
                index++;
            }
        }

        static void Sort(T[] v, int left, int right)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;

            Sort(v, left, middle);
            Sort(v, middle + 1, right);

            Merge(v, left, middle, middle + 1, right);
        }

        static void Sort(T[] v)
        {
            Sort(v, 0, v.Length - 1);
        }

        static void Print(T[] v)
        {
            foreach(T t in v)
                Console.WriteLine(t);
        }
    }
}
