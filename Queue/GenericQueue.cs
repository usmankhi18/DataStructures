using System.Collections.Generic;
using System;

namespace DataStructures.Queue
{
    // Implementation of the queue using Queue class
    public class GenericQueue : IQueue
    {
        private Queue<int> queue;

        public GenericQueue()
        {
            queue = new Queue<int>();
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return queue.Peek();
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public bool IsFull()
        {
            // Since Queue<T> doesn't have a fixed capacity, it's never "full"
            return false;
        }

        public int Size()
        {
            return queue.Count;
        }

        public void Insert(int data)
        {
            queue.Enqueue(data);
        }

        public int RemoveData()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return queue.Dequeue();
        }
    }
}