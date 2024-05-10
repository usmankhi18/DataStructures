using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree.BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITreeOperations bst = new BinarySearchTree();
            bst.Insert(55);
            bst.Insert(20);
            bst.Insert(90);
            bst.Insert(80);
            bst.Insert(50);
            bst.Insert(35);
            bst.Insert(15);
            bst.Insert(65);

            bst.PrintTree();
            bst.Delete(55);
            Console.WriteLine($"Element found = {bst.Search(80)}");
            Console.WriteLine($"Is Tree Empty? {bst.IsEmpty()}");
            Console.ReadKey();
        }
    }
}
