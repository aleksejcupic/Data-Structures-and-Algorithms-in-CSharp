using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Graph<T>
    {
        public GraphNode<T>[] nodes;

        void DFSearch(GraphNode<T> root)
        {
            if (root == null)
            {
                Visit(root);
                root.Visited = true;
                foreach (GraphNode<T> node in nodes)
                {
                    if (node.Visited == false)
                        DFSearch(node);
                }
            }
        }

        void BFSearch(GraphNode<T> root)
        {
            Queue<GraphNode<T>> queue = new();
            root.Visited = true;
            queue.Enqueue(root);

            while (!queue.IsEmpty())
            {
                GraphNode<T> r = queue.Dequeue();
                Visit(r);
                foreach(GraphNode<T> node in r.Children) {
                    if (node.Visited == false)
                    {
                        node.Visited = true;
                        queue.Enqueue(node);
                    }
                }
            }
        }

        void Visit(GraphNode<T> node)
        {
            // perform work
        }
    }

    internal class GraphNode<T>
    {
        public T Data;
        public bool Visited;
        public GraphNode<T>[] Children;
    }
}
