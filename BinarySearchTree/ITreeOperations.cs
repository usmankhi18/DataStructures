namespace DataStructures.Tree.BinarySearchTree
{
    public interface ITreeOperations
    {
        bool IsEmpty();
        void Insert(int data);
        void Delete(int data);
        bool Search(int data);
        void PrintTree();
    }
}