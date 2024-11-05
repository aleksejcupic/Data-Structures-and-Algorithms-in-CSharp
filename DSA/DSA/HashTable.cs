using System.Linq.Expressions;

namespace DSA
{
    internal class HashTable<TKey, TValue>(Expression<Func<TKey, int>> hashExpression)
    {
        private readonly LinkedList<TKey, TValue>[] _hashTableArray = new LinkedList<TKey, TValue>[1];

        private readonly Func<TKey, int> _hashFunction = hashExpression.Compile();

        private int GetHash(TKey key) => _hashFunction(key) % _hashTableArray.Length;

        internal void Insert(KeyValuePair<TKey, TValue> obj) => (_hashTableArray[GetHash(obj.Key)] ??= new LinkedList<TKey, TValue>()).Insert(obj);

        internal TValue? Get(TKey key) => _hashTableArray[GetHash(key)].Find(key) ?? default;

        internal void Remove(TKey key)
        {
            var linkedList = _hashTableArray[GetHash(key)];

            for (linkedList.GetHead(); linkedList.Get().Equals(key); linkedList.Next())
                continue;
            linkedList.Remove();
        }
    }
}