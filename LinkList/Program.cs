using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures.LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singly Linked List:");
            Console.WriteLine("-------------------");
            DemoSinglyLinkedList();
            Console.WriteLine("\nDoubly Linked List:");
            Console.WriteLine("-------------------");
            DemoDoublyLinkedList();
            Console.WriteLine("\nCircular Linked List:");
            Console.WriteLine("-------------------");
            DemoCircularLinkedList();
            Console.ReadKey();
        }

        static void DemoSinglyLinkedList()
        {
            // Create a singly linked list
            ILinkedList linkedList = new CustomLinkedList();

            // Perform operations on the singly linked list
            PerformLinkedListOperations(linkedList);

            // Create a generic singly linked list
            linkedList = new GenericLinkedList();

            // Perform operations on the generic singly linked list
            PerformLinkedListOperations(linkedList);
        }

        static void DemoDoublyLinkedList()
        {
            // Create a doubly linked list
            ILinkedList doublyLinkedList = new CustomDoublyLinkedList();

            // Perform operations on the doubly linked list
            PerformLinkedListOperations(doublyLinkedList);

            // Create a generic doubly linked list
            doublyLinkedList = new GenericDoublyLinkedList();

            // Perform operations on the generic doubly linked list
            PerformLinkedListOperations(doublyLinkedList);
        }

        static void DemoCircularLinkedList()
        {
            // Create a circualr linked list
            ILinkedList circularLinkedList = new CustomCircularLinkedList();

            // Perform operations on the circular linked list
            PerformLinkedListOperations(circularLinkedList);

            // Create a generic circular linked list
            circularLinkedList = new GenericCircularLinkedList();

            // Perform operations on the generic circular linked list
            PerformLinkedListOperations(circularLinkedList);
        }

        static void PerformLinkedListOperations(ILinkedList list)
        {
            // Insert some elements at the beginning
            list.InsertAtBeginning(12);
            list.InsertAtBeginning(22);
            list.InsertAtBeginning(30);
            list.InsertAtBeginning(44);
            list.InsertAtBeginning(50);

            // Insert some elements at the end
            list.InsertAtEnd(32);
            list.InsertAtEnd(40);
            list.InsertAtEnd(54);
            list.InsertAtEnd(60);

            // Insert after a specific node
            list.InsertAfterNode(50, 33);
            list.InsertAfterNode(33, 50);

            // Print the list
            Console.WriteLine("Current list:");
            list.PrintList();

            // Delete elements
            list.DeleteAtBeginning();
            list.DeleteAtEnd();
            list.DeleteNode(12);

            // Print the list after deletion
            Console.WriteLine("List after deletion:");
            list.PrintList();

            // Reverse the list
            list.Reverse();
            Console.WriteLine("Reversed list:");
            list.PrintList();

            // Search for an element
            int ele = 44;
            Console.Write($"Searching for element {ele}: ");
            if (list.Search(ele))
            {
                Console.WriteLine("Element is found");
            }
            else
            {
                Console.WriteLine("Element is not found in the list");
            }

            Console.WriteLine();
        }
    }
}
