using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkList
{
    internal class CustomCircularLinkedList : ILinkedList
    {
        class Node
        {
            public int data;
            public Node prev;
            public Node next;

            public Node(int value)
            {
                data = value;
                prev = null;
                next = null;
            }
        }

        private Node head;
        private Node tail;

        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                newNode.next = newNode;
                newNode.prev = newNode;
            }
            else
            {
                newNode.next = head;
                newNode.prev = tail;
                head.prev = newNode;
                tail.next = newNode;
                head = newNode;
            }
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                newNode.next = newNode;
                newNode.prev = newNode;
            }
            else
            {
                newNode.next = head;
                newNode.prev = tail;
                head.prev = newNode;
                tail.next = newNode;
                tail = newNode;
            }
        }

        public void InsertAfterNode(int data, int key)
        {
            Node newNode = new Node(data);
            Node current = head;
            while (current != null && current.data != key)
            {
                current = current.next;
                if (current == head)
                {
                    Console.WriteLine("Key not found");
                    return;
                }
            }
            newNode.next = current.next;
            newNode.prev = current;
            current.next.prev = newNode;
            current.next = newNode;
        }

        public void DeleteAtBeginning()
        {
            if (head != null)
            {
                if (head == head.next)
                {
                    head = null;
                }
                else
                {
                    head.next.prev = tail;
                    tail.next = head.next;
                    head = head.next;
                }
            }
        }

        public void DeleteAtEnd()
        {
            if (head != null)
            {
                if (head == head.next)
                {
                    head = null;
                }
                else
                {
                    tail.prev.next = head;
                    head.prev = tail.prev;
                    tail = tail.prev;
                }
            }
        }

        public void DeleteNode(int key)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node current = head;
            while (current != null && current.data != key)
            {
                current = current.next;
                if (current == head)
                {
                    Console.WriteLine("Key not found");
                    return;
                }
            }

            if (current == head)
            {
                DeleteAtBeginning();
                return;
            }

            current.prev.next = current.next;
            current.next.prev = current.prev;
        }

        public void Reverse()
        {
            // Circular linked list reversal doesn't change the structure
            // Just make head point to the previous node
            if (head != null)
            {
                head = head.prev;
            }
        }

        public bool Search(int key)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == key)
                {
                    return true;
                }
                current = current.next;
                if (current == head)
                {
                    break;
                }
            }
            return false;
        }

        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("Circular Linked List is empty");
                return;
            }

            Node current = head;
            do
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            while (current != head);
            Console.WriteLine();
        }
    }
}
