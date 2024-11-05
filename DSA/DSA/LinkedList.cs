namespace DSA
{
    internal class LinkedList<TKey, TValue>
    {
        LinkedListNode<TKey, TValue>? Head;
        internal LinkedListNode<TKey, TValue>? Current;
        LinkedListNode<TKey, TValue>? Previous;

        public TValue? Get()
        {
            return Current != null ? Current.GetData() : default;
        }

        public void Next()
        {
            if (Current != null) 
            {
                Previous = Current;
                Current = Current.Next;
            }
        }

        public void GetHead()
        {
            Previous = null;
            Current = Head; 
        }

        public void Insert(KeyValuePair<TKey, TValue> data)
        {
            LinkedListNode<TKey, TValue> node = new(data.Key, data.Value)
            {
                Next = Current!
            };

            if (Current == Head)
                Head = node;
            else
                Previous!.Next = node;

            Current = node;
        }

        public void Remove()
        {
            if (Current == null)
                throw new Exception("Invalid position to remove");

            if (Current == Head)
                Head = Current.Next;
            else
                Previous!.Next = Current.Next;

            Current = Current.Next;
        }

        public void Print()
        {
            for (GetHead(); Get() != null; Next())
                Console.WriteLine(Get());
        }
    }

    internal static class LinkedListExtensions
    {

        internal static TValue Find<TKey, TValue>(this LinkedList<TKey, TValue> linkedList, TKey key)
        {
            for (linkedList.GetHead(); linkedList.Current.Key.Equals(key); linkedList.Next())
                continue;
            return linkedList.Get();
        }
    }
}
