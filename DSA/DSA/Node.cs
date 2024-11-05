using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class LinkedListNode<TKey, TValue>(TKey key, TValue value)
    {
        public LinkedListNode<TKey, TValue> Next;

        internal readonly TKey Key = key;
        internal readonly TValue Value = value;

        public TValue GetData()
        {
            return Value;
        }
    }
}
