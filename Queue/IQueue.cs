namespace DataStructures.Queue
{
    // Interface for the queue
    public interface IQueue
    {
        int Peek();
        bool IsEmpty();
        bool IsFull();
        int Size();
        void Insert(int data);
        int RemoveData();
    }
}