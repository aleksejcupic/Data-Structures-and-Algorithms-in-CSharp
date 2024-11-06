namespace DSA
{
    // From Cracking the Coding Interview
    internal class HashMapList<T, E>
    {
        private Dictionary<T, ArrayList<E>> Map = [];

        public void Put(T key, E item)
        {
            if (!Map.ContainsKey(key))
                Map[key] = new();

            Map.TryGetValue(key, out var list);
            list.Add(item);
        }

        public void Put(T key, ArrayList<E> items) => Map[key] = items;

        public void Get(T key, out ArrayList<E> list) => _ = Map.TryGetValue(key, out list);

        public bool ContainsKey(T key) => Map.ContainsKey(key);

        public bool ContainsKeyValue(T key, E value)
        {
            Get(key, out ArrayList<E> list);
            if (list == null) return false;
            return list.Contians(value);
        }

        public ISet<T> KeySet() => Map.Keys.ToHashSet();

        public override string ToString() => Map.ToString();

    }
}
