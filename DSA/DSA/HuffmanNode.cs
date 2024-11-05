using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class HuffmanNode<T> where T : IComparable<T>
    {
        public int frequency;
        public HuffmanNode<T> left;
        public HuffmanNode<T> right;
        public int code;
        public string huffmanCode;

        public HuffmanNode(int code)
        {
            this.code = code;
        }

        public int CompareTo(T other)
        {
            HuffmanNode<T> otherNode = (HuffmanNode<T>)other;

            if (frequency < otherNode.frequency)
                return 1;
            else if (frequency > otherNode.frequency) return -1;
            else return 0;
        }

        public void SetHuffmanCode(string code)
        {
            this.huffmanCode = code;
            left?.SetHuffmanCode(code + "0");
            right?.SetHuffmanCode(code + "1");
        }
    }
}
