using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class BinarySearchTree<T>
    {
        TreeNode<T> Root;
        TreeNode<T>[] Nodes;

        public void CreateLeafNodes(string text)
        {
            Nodes = new TreeNode<T>[256];
            for (int i = 0; i < text.Length; i++)
            {
                int code = text[i];
                if (Nodes[code] == null)
                    Nodes[code] = new TreeNode<T>(code);

                Nodes[code].Frequency++;
            }
        }

        public void BuildTree<T>()
        {
            Heap<TreeNode<T>> heap = new();

            for (int i = 0; i < 256; i++)
            {
                if (Nodes[i] != null)
                    heap.Insert(Nodes[i]);

            }

            while (heap.GetLength() > 1)
            {
                TreeNode left = (TreeNode)heap.ExtractMax();
                TreeNode right = (TreeNode)heap.ExtractMax();

                Root = new TreeNode<T>(0)
                {
                    left = left,
                    right = right,
                    frequency = left.frequency + right.frequency
                };

                heap.Insert(Root);
            }

            root.SetHuffmanCode("");

        }

        public string Encode(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                int code = text.CharAt(i);
                if (Nodes[code] == null)
                {
                    throw new Exception("Character not supported" + text.charAt(i));
                }

                string huffman_code = Nodes[code].huffman_code;

                result += huffman_code;

            }
            return result;
        }
    }
}
