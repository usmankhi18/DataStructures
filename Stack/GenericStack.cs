using System.Collections.Generic;
using System;

namespace DataStructures.Stack
{
    internal class GenericStack : IStack
    {
        private Stack<int> stack;

        public GenericStack()
        {
            stack = new Stack<int>();
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public bool IsFull()
        {
            // Generic Stack doesn't have a maximum capacity, so IsFull() always returns false
            return false;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            return stack.Peek();
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            return stack.Pop();
        }

        public void Push(int item)
        {
            stack.Push(item);
        }
    }
}