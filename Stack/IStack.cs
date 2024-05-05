namespace DataStructures.Stack
{
    internal interface IStack
    {
        bool IsEmpty();
        bool IsFull();
        int Peek();
        int Pop();
        void Push(int data);
    }
}