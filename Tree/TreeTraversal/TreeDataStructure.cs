using System;

namespace DataStructures.Tree.TreeTraversal
{
    public class TreeDataStructure
    {
        public Node root = null;

        // Methods for traversals
        public void InorderTraversal()
        {
            var traversal = new InOrderTraversal();
            Console.WriteLine("Inorder traversal: ");
            traversal.Traverse(root);
        }

        public void PreorderTraversal()
        {
            var traversal = new PreOrderTraversal();
            Console.WriteLine("\nPreorder traversal: ");
            traversal.Traverse(root);
        }

        public void PostorderTraversal()
        {
            var traversal = new PostOrderTraversal();
            Console.WriteLine("\nPostorder traversal: ");
            traversal.Traverse(root);
        }
    }
}