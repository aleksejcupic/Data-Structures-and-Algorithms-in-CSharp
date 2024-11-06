using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Stack<T>
    {
        internal class StackNode<T>(T Data)
        {
            internal readonly T? Data = Data;
            internal StackNode<T>? Next;
        }

        private StackNode<T> Top;

        public T Pop()
        {
            if (Top == null) throw new Exception();
            T item = Top.Data;

            Top = Top.Next;
            return item;
        }

        public void Push(T item)
        {
            StackNode<T> t = new StackNode<T>(item);
            t.Next = Top;
            Top = t;
        }

        public T Peek()
        {
            if (Top == null) throw new Exception();
            return Top.Data;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
