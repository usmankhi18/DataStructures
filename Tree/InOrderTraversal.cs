using System;

namespace DataStructures.Tree
{
    public class InOrderTraversal<T> : ITraversal<T> where T : IComparable<T>
    {
        public void Traverse(INode<T> root)
        {
            if (root != null)
            {
                Traverse(root.Left);
                Console.Write(root.Data + " ");
                Traverse(root.Right);
            }
        }
    }
}