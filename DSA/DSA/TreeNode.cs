using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class TreeNode<T>(IComparable key, T data)
    {
        IComparable Key = key;
        T Data = data;
        public int Frequency;

        public TreeNode<T> parent;
        public TreeNode<T> left;
        public TreeNode<T> right;

        public IComparable GetKey() => Key;
        public T GetData() => Data;
    }
}
