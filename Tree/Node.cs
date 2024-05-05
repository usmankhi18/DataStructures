using System;

namespace DataStructures.Tree
{
    public class Node<T> : INode<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public INode<T> Left { get; set; }
        public INode<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}