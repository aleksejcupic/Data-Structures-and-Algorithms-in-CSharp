namespace DSA
{
    internal class StringBuilder
    {
        private ArrayList<char> _chars = new ArrayList<char>();

        public StringBuilder Append(string str)
        {
            foreach (char c in str)
                _chars.Add(c);
            
            return this;
        }
        public StringBuilder Append(char c)
        {
            _chars.Add(c);
            return this;
        }

        public StringBuilder Insert(int index, string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
                _chars.Add(index, str[i]);

            return this;
        }

        public override string ToString()
        {
            char[] result = new char[_chars.Size];
            for (int i = 0; i < _chars.Size; i++)
                result[i] = _chars[i];

            return new string(result);
        }
    }
}
