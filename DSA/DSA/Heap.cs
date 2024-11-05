using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Heap<T> where T : IComparable<T>
    {
        Vector<T> vector = new Vector<T>();

        int Parent(int index) => (index - 1) / 2;
        int Left(int index) => index * 2 + 1;
        int Right(int index) => index * 2 + 2;

        public IComparable Get(int index) => (IComparable)vector.Get(index);

        public int GetLength() => vector.GetLength();

        void Sink(int index)
        {
            int left = Left(index);
            int right = Right(index);

            int max = index;

            if (left < GetLength() && Get(left).CompareTo(Get(max)) > 0)
                max = left;

            if (right < GetLength() && Get(right).CompareTo(Get(max)) > 0)
                max = right;

            if (max != index)
            {
                vector.Swap(index, max);
                Sink(max);
            }
        }

        void Float(int index)
        {
            if (index == 0) return;

            int parent = Parent(index);

            if (Get(index).CompareTo(Get(parent)) > 0)
            {
                vector.Swap(index, parent);
                Float(parent);
            }
        }

        public void Insert(T item)
        {
            vector.Add(item);
            Float(GetLength() - 1);
        }

        public IComparable ExtractMax()
        {
            if (GetLength() == 0)
                throw new Exception("Heap is empty");

            IComparable max_object = Get(0);
            vector.Swap(0, GetLength() - 1);
            vector.Remove(GetLength() - 1);
            Sink(0);
            return max_object;
            
        }
    }
}
