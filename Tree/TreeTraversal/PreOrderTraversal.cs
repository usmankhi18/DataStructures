using System;

namespace DataStructures.Tree.TreeTraversal
{
    public class PreOrderTraversal : ITraversal
    {
        public void Traverse(Node node)
        {
            if (node != null)
            {
                Console.Write(node.data + " ");
                Traverse(node.leftChild);
                Traverse(node.rightChild);
            }
        }
    }
}