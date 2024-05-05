using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkList
{
    internal class CustomDoublyLinkedList : ILinkedList
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
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
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
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
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
            if (current.next != null)
            {
                current.next.prev = newNode;
            }
            current.next = newNode;
            newNode.prev = current;
        }

        public void DeleteAtBeginning()
        {
            if (head != null)
            {
                head = head.next;
                if (head != null)
                {
                    head.prev = null;
                }
                else
                {
                    tail = null;
                }
            }
        }

        public void DeleteAtEnd()
        {
            if (tail != null)
            {
                tail = tail.prev;
                if (tail != null)
                {
                    tail.next = null;
                }
                else
                {
                    head = null;
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
            if (head.data.Equals(key))
            {
                head = head.next;
                if (head != null)
                {
                    head.prev = null;
                }
                else
                {
                    tail = null;
                }
                return;
            }
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
            if (current.next != null)
            {
                current.next.prev = current.prev;
            }
            current.prev.next = current.next;
        }

        public void Reverse()
        {
            Node temp = null;
            Node current = head;
            while (current != null)
            {
                temp = current.prev;
                current.prev = current.next;
                current.next = temp;
                current = current.prev;
            }
            if (temp != null)
            {
                head = temp.prev;
            }
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
            Console.Write("Doubly Linked List: ");
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
