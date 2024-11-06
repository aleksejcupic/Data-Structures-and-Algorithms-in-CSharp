namespace DSA
{
    public class ArrayList<T>
    {
        private T[] _items = new T[1];
        private int _size = 0;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _size) throw new Exception(nameof(index)); else return _items[index];
            }
            set
            {
                if (index < 0 || index >= _size) throw new Exception(nameof(index)); else _items[index] = value;
            }
        }

        public int Size => _size;

        public void Add(T item)
        {
            if (_size == _items.Length)
                Resize();

            _items[_size++] = item;
        }

        public void Add(int index, T item)
        {
            if (index < 0 || index > _size)
            {
                throw new Exception(nameof(index));
            }
            ShiftAtIndex(index);
            _items[index] = item;
        }

        private void ShiftAtIndex(int index)
        {
            if (_size == _items.Length)
                Resize();

            for (int i = _size; i > index; i--) 
                _items[i] = _items[i - 1];

            _size++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new Exception(nameof(index));
            }
            for (int i = index; i < _size - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _items[_size - 1] = default;
            _size--;
        }

        private void Resize()
        {
            T[] newItems = new T[_items.Length * 2];
            Array.Copy(_items, newItems, _size);
            _items = newItems;
        }

        public void Clear()
        {
            _items = [default];
            _size = 0;
        }

        public bool Contians(T item)
        {
            return _items.Contains(item);
        }
    }
}
