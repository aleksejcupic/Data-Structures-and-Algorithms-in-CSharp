using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Queue<T>
    {
        internal class QueueNode<T>(T data)
        {
            internal T Data = data;
            internal QueueNode<T> Next;
        }

        private QueueNode<T> First;
        private QueueNode<T> Last;

        public void Enqueue(T item)
        {
            QueueNode<T> t = new QueueNode<T>(item);
            if (Last != null)
            {
                Last.Next = t;
            }

            Last = t;
            if (First == null)
            {
                First = Last;
            }
        }

        public T Dequeue()
        {
            if (First == null) throw new Exception();
            T data = First.Data;
            First = First.Next;
            if (First == null)
                Last = null;

            return data;
        }

        public T Peek()
        {
            if (First == null) throw new Exception();
            return First.Data;
        }

        public bool IsEmpty()
        {
            return First == null;
        }
    }
}
