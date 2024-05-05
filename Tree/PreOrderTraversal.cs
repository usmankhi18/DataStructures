using System;

namespace DataStructures.Tree
{
    public class PreOrderTraversal<T> : ITraversal<T> where T : IComparable<T>
    {
        public void Traverse(INode<T> root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                Traverse(root.Left);
                Traverse(root.Right);
            }
        }
    }
}