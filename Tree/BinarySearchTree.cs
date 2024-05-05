using System;

namespace DataStructures.Tree
{
    public class BinarySearchTree<T> : IBinarySearchTree<T> where T : IComparable<T>
    {
        private INode<T> root;

        public void Insert(T data)
        {
            root = InsertRec(root, data);
        }

        private INode<T> InsertRec(INode<T> root, T data)
        {
            if (root == null)
            {
                root = new Node<T>(data);
                return root;
            }

            if (data.CompareTo(root.Data) < 0)
            {
                root.Left = InsertRec(root.Left, data);
            }
            else if (data.CompareTo(root.Data) > 0)
            {
                root.Right = InsertRec(root.Right, data);
            }

            return root;
        }

        public bool Search(T data)
        {
            return SearchRec(root, data);
        }

        private bool SearchRec(INode<T> root, T data)
        {
            if (root == null)
                return false;

            if (root.Data.Equals(data))
                return true;

            if (data.CompareTo(root.Data) < 0)
                return SearchRec(root.Left, data);
            else
                return SearchRec(root.Right, data);
        }

        public void InOrderTraversal()
        {
            var traversal = new InOrderTraversal<T>();
            traversal.Traverse(root);
            Console.WriteLine();
        }

        public void PreOrderTraversal()
        {
            var traversal = new PreOrderTraversal<T>();
            traversal.Traverse(root);
            Console.WriteLine();
        }

        public void PostOrderTraversal()
        {
            var traversal = new PostOrderTraversal<T>();
            traversal.Traverse(root);
            Console.WriteLine();
        }

        public void Delete(T data)
        {
            root = DeleteRec(root, data);
        }

        private INode<T> DeleteRec(INode<T> root, T data)
        {
            if (root == null)
                return root;

            if (data.CompareTo(root.Data) < 0)
                root.Left = DeleteRec(root.Left, data);
            else if (data.CompareTo(root.Data) > 0)
                root.Right = DeleteRec(root.Right, data);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Data = MinValue(root.Right);

                root.Right = DeleteRec(root.Right, root.Data);
            }
            return root;
        }

        private T MinValue(INode<T> node)
        {
            T minv = node.Data;
            while (node.Left != null)
            {
                minv = node.Left.Data;
                node = node.Left;
            }
            return minv;
        }

        public void PrintTree()
        {
            var printer = new TreePrinter<T>();
            printer.PrintTree(root, 0);
        }
    }
}