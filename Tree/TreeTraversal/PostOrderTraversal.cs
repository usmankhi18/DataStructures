using System;

namespace DataStructures.Tree.TreeTraversal
{
    public class PostOrderTraversal : ITraversal
    {
        public void Traverse(Node node)
        {
            if (node != null)
            {
                Traverse(node.leftChild);
                Traverse(node.rightChild);
                Console.Write(node.data + " ");
            }
        }
    }
}