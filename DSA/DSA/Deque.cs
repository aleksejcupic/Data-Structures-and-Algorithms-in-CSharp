using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Deque<T>
    {
        int length;
        int size;
        T[] items;
        int left;

        internal Deque()
        {
            size = 2;
            items = new T[size];
        }

        int GetPhysicalIndex(int index) => (left + index + size) % size;
        
        void Grow()
        {
            T[] new_items = new T[size * 2];
            for (int i = 0; i < size; i++)
                new_items[i] = items[GetPhysicalIndex(i)];

            size = size * 2;
            items = new_items;
            left = 0;
        }

        void ExpandLeft(int index)
        {
            for (int i = 0; i < index; i++)
                items[GetPhysicalIndex(i - 1)] = items[GetPhysicalIndex(i)];

            left = GetPhysicalIndex(-1);
        }

        void ExpandRight(int index)
        {
            for (int i = length - 1; i >= index; i--)
                items[GetPhysicalIndex(i + 1)] = items[GetPhysicalIndex(-i)];
        }

        public T Get(int index) => index >= 0 && index < length ? items[GetPhysicalIndex(index)] : default;

        public void Insert(int index, T item)
        {
            if (index < 0 || index > length) 
                throw new ArgumentOutOfRangeException("Invalid index");

            if (length == size)
                Grow();

            if (index < length / 2)
                ExpandLeft(index);
            else
                ExpandRight(index);

            items[GetPhysicalIndex(index)] = item;
            length++;
        }

        public void Print()
        {
            foreach(T t in items)
                Console.WriteLine(t);
        }
    }
}
