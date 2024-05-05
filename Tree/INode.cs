using System;

namespace DataStructures.Tree
{
    public interface INode<T> where T : IComparable<T>
    {
        T Data { get; set; }
        INode<T> Left { get; set; }
        INode<T> Right { get; set; }
    }
}