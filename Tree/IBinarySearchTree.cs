using System;

namespace DataStructures.Tree
{
    public interface IBinarySearchTree<T> where T : IComparable<T>
    {
        void Insert(T data);
        bool Search(T data);
        void InOrderTraversal();
        void PreOrderTraversal();
        void PostOrderTraversal();
        void Delete(T data);
        void PrintTree();
    }
}