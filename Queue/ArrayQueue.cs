using System;

namespace DataStructures.Queue
{
    // Implementation of the queue using an array
    public class ArrayQueue : IQueue
    {
        private readonly int MAX;
        private readonly int[] intArray;
        private int front;
        private int rear;
        private int itemCount;

        public ArrayQueue(int maxSize)
        {
            MAX = maxSize;
            intArray = new int[MAX];
            front = 0;
            rear = -1;
            itemCount = 0;
        }

        public int Peek()
        {
            return intArray[front];
        }

        public bool IsEmpty()
        {
            return itemCount == 0;
        }

        public bool IsFull()
        {
            return itemCount == MAX;
        }

        public int Size()
        {
            return itemCount;
        }

        public void Insert(int data)
        {
            if (!IsFull())
            {
                if (rear == MAX - 1)
                {
                    rear = -1;
                }
                intArray[++rear] = data;
                itemCount++;
            }
        }

        public int RemoveData()
        {
            int data = intArray[front++];
            if (front == MAX)
            {
                front = 0;
            }
            itemCount--;
            return data;
        }

        // Public method to access the intArray
        public int GetElementAtIndex(int index)
        {
            return intArray[index];
        }
    }
}