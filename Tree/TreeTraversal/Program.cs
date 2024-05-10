using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures.Tree.TreeTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            TreeDataStructure tree = new TreeDataStructure();
            tree.root = new Node(27);
            tree.root.leftChild = new Node(12);
            tree.root.rightChild = new Node(3);
            tree.root.leftChild.leftChild = new Node(44);
            tree.root.leftChild.rightChild = new Node(17);
            tree.root.rightChild.leftChild = new Node(56);

            tree.InorderTraversal();
            tree.PreorderTraversal();
            tree.PostorderTraversal();

            Console.ReadKey();
        }
    }
}
