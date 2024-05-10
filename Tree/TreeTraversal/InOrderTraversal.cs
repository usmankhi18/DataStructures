using System;

namespace DataStructures.Tree.TreeTraversal
{
    public class InOrderTraversal : ITraversal
    {
        public void Traverse(Node node)
        {
            if (node != null)
            {
                Traverse(node.leftChild);
                Console.Write(node.data + " ");
                Traverse(node.rightChild);
            }
        }
    }
}