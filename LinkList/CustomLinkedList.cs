using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkList
{
    class CustomLinkedList : ILinkedList
    {
        class Node
        {
            public int data;
            public Node next;

            public Node(int value)
            {
                data = value;
                next = null;
            }
        }

        private Node head;

        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }

        public void InsertAfterNode(int data, int key)
        {
            Node newNode = new Node(data);
            Node current = head;
            while (current != null && !current.data.Equals(key))
            {
                current = current.next;
            }
            if (current == null)
            {
                Console.WriteLine("Key not found");
                return;
            }
            newNode.next = current.next;
            current.next = newNode;
        }

        public void DeleteAtBeginning()
        {
            if (head != null)
            {
                head = head.next;
            }
        }

        public void DeleteAtEnd()
        {
            if (head == null || head.next == null)
            {
                head = null;
                return;
            }
            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;
        }

        public void DeleteNode(int key)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.data.Equals(key))
            {
                head = head.next;
                return;
            }
            Node current = head;
            Node prev = null;
            while (current != null && !current.data.Equals(key))
            {
                prev = current;
                current = current.next;
            }
            if (current == null)
            {
                Console.WriteLine("Key not found");
                return;
            }
            prev.next = current.next;
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public bool Search(int key)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data.Equals(key))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public void PrintList()
        {
            Node current = head;
            Console.Write("Linked List: ");
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
