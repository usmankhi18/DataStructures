using System;

namespace DataStructures.Tree
{
    public class TreePrinter<T> where T : IComparable<T>
    {
        public void PrintTree(INode<T> root, int level)
        {
            if (root == null)
                return;

            PrintTree(root.Right, level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
                Console.Write("   ");

            Console.WriteLine(root.Data);

            PrintTree(root.Left, level + 1);
        }
    }
}