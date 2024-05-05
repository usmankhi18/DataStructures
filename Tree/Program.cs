using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures.Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);

            Console.WriteLine("Inorder traversal:");
            bst.InOrderTraversal();

            Console.WriteLine("Preorder traversal:");
            bst.PreOrderTraversal();

            Console.WriteLine("Postorder traversal:");
            bst.PostOrderTraversal();

            Console.WriteLine("Tree structure after insertion:");
            bst.PrintTree();

            Console.WriteLine("Searching for 20: " + bst.Search(20));
            Console.WriteLine("Searching for 90: " + bst.Search(90));

            Console.WriteLine("Tree structure:");
            bst.PrintTree();

            bst.Delete(20);
            Console.WriteLine("Inorder traversal after deleting 20:");
            bst.InOrderTraversal();

            Console.WriteLine("Tree structure after deletion:");
            bst.PrintTree();
            Console.ReadKey();
        }
    }
}
