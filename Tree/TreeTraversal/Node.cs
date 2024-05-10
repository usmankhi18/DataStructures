namespace DataStructures.Tree.TreeTraversal
{
    public class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;

        public Node(int key)
        {
            data = key;
            leftChild = rightChild = null;
        }
    }
}