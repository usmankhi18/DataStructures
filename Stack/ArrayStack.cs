using System;

namespace DataStructures.Stack
{
    internal class ArrayStack : IStack
    {
        private const int MAXSIZE = 8;
        private int[] stack;
        private int top;

        public ArrayStack()
        {
            stack = new int[MAXSIZE];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == MAXSIZE - 1;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            return stack[top];
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            return stack[top--];
        }

        public void Push(int data)
        {
            if (IsFull())
                throw new InvalidOperationException("Stack is full.");
            stack[++top] = data;
        }
    }
}