using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{

    internal class HashTableBST<TKey, TValue>
    {
        private 
        private HashTreeNode root;

        private Func<TKey, int> _hashFunction;

        private int GetHash(TKey key)
        {
            return _hashFunction(key) % root.height;
        }

        internal HashTableBST(Expression<Func<TKey, int>> hashExpression)
        {
            root = new HashTreeNode();
            _hashFunction = hashExpression.Compile();
        }

        internal void Insert(KeyValuePair<TKey, TValue> obj)
        {
            var index = GetHash(obj.Key);
            var linkedList = hashTableArray[index] ??= new LinkedList<KeyValuePair<TKey, TValue>>();
            linkedList.AddLast(obj);

        }

        private TValue GetFromLinkedList(LinkedList<KeyValuePair<TKey, TValue>> linkedList, TKey key)
        {
            return linkedList.FirstOrDefault(x => x.Key.Equals(key)).Value;
        }

        internal TValue Get(TKey key)
        {
            var linkedList = GetLinkedList(key);
            return GetFromLinkedList(linkedList, key);
        }

        private LinkedList<KeyValuePair<TKey, TValue>> GetLinkedList(TKey key)
        {
            return hashTableArray[GetHash(key)];
        }

        internal void Remove(TKey key)
        {
            var linkedList = GetLinkedList(key);
            var value = GetFromLinkedList(linkedList, key);
            linkedList.Remove(new KeyValuePair<TKey, TValue>(key, value));
        }

        internal class HashTreeNode
        {
            LinkedList<KeyValuePair<TKey, TValue>> Value;
            internal int height;
            HashTreeNode Left;
            HashTreeNode Right;

            internal HashTreeNode()
            {
                Value = new LinkedList<KeyValuePair<TKey, TValue>>();
                this.height = 1;
                Left = null;
                Right = null;
            }
        }
    }
}
