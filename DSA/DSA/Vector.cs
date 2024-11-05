using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Vector<T>
    {
        int length;
        int size;
        T[] items;

        void Grow()
        {
            size = size * 2;

            T[] new_items = new T[size];

            for (int i = 0; i < length; i++)
            {
                new_items[i] = items[i];
            }

            items = new_items;
        }

        public Vector()
        {
            size = 2;
            items = new T[size];
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > length)
                return;

            if (length == size)
                Grow();

            for (int i = length - 1; i >= index; i--)
                items[i + 1] = items[i];

            items[index] = item;
            length++;
        }

        public void Add(T item) => Insert(length, item);

        public void Remove(int index)
        {
            if (index == 0 || index >= length) return;

            for (int i = index + 1; i < length; i++)
                items[i - 1] = items[i];

            items[length - 1] = null;

            length--;
        }

        public T Get(int index) => index >= 0 && index < length ? items[index] : null;

        public int GetLength() => length;

        public void Print()
        {
            foreach(T t in items)
                Console.WriteLine(t);
        }

        public void Swap(int index1, int index2)
        {
            (items[index2], items[index1]) = (items[index1], items[index2]);
        }
    }
}
