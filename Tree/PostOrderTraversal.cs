using System;

namespace DataStructures.Tree
{
    public class PostOrderTraversal<T> : ITraversal<T> where T : IComparable<T>
    {
        public void Traverse(INode<T> root)
        {
            if (root != null)
            {
                Traverse(root.Left);
                Traverse(root.Right);
                Console.Write(root.Data + " ");
            }
        }
    }
}