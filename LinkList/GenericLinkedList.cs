using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkList
{
    internal class GenericLinkedList : ILinkedList
    {
        private LinkedList<int> linkedList;

        public GenericLinkedList()
        {
            linkedList = new LinkedList<int>();
        }

        public void InsertAtBeginning(int data)
        {
            linkedList.AddFirst(data);
        }

        public void InsertAtEnd(int data)
        {
            linkedList.AddLast(data);
        }

        public void InsertAfterNode(int data, int key)
        {
            LinkedListNode<int> node = linkedList.Find(key);
            if (node != null)
            {
                linkedList.AddAfter(node, data);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }

        public void DeleteAtBeginning()
        {
            if (linkedList.Count > 0)
            {
                linkedList.RemoveFirst();
            }
        }

        public void DeleteAtEnd()
        {
            if (linkedList.Count > 0)
            {
                linkedList.RemoveLast();
            }
        }

        public void DeleteNode(int key)
        {
            linkedList.Remove(key);
        }

        public void Reverse()
        {
            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (int item in linkedList)
            {
                reversedList.AddFirst(item);
            }
            linkedList = reversedList;
        }

        public bool Search(int key)
        {
            return linkedList.Contains(key);
        }

        public void PrintList()
        {
            Console.Write("Linked List: ");
            foreach (int item in linkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}