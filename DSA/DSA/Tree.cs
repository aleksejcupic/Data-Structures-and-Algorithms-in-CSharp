using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class BinaryTree
    {
        public BinaryTreeNode root;

        void InOrderTraversal(BinaryTreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Visit(node);
                InOrderTraversal(node.Right);
            }
        }

        void PreOrderTraversal(BinaryTreeNode node)
        {
            if (node != null)
            {
                Visit(node);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        void PostOrderTraversal(BinaryTreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Visit(node);
            }
        }

        void Visit(BinaryTreeNode node)
        {
            // perform work
        }
    }

    internal class TreeNode
    {
        public string Name;
        public TreeNode[] Children;
    }

    internal class BinaryTreeNode
    {
        public string Name;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;
    }
}
