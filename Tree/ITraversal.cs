using System;

namespace DataStructures.Tree
{
    public interface ITraversal<T> where T : IComparable<T>
    {
        void Traverse(INode<T> root);
    }
}