using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.List
{
    internal class Program
    {
        static List<int> list = new List<int>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("List Operations:");
                Console.WriteLine("1. Insertion");
                Console.WriteLine("2. Deletion");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Traversal");
                Console.WriteLine("5. Update");
                Console.WriteLine("6. Display");
                Console.WriteLine("7. Sorting");
                Console.WriteLine("8. Reversal");
                Console.WriteLine("9. Maximum and Minimum Element");
                Console.WriteLine("10. Check if Element Exists");
                Console.WriteLine("11. Clear List");
                Console.WriteLine("12. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ListInsertion();
                        break;
                    case 2:
                        ListDeletion();
                        break;
                    case 3:
                        ListSearch();
                        break;
                    case 4:
                        ListTraversal();
                        break;
                    case 5:
                        ListUpdate();
                        break;
                    case 6:
                        ListDisplay();
                        break;
                    case 7:
                        ListSorting();
                        break;
                    case 8:
                        ListReversal();
                        break;
                    case 9:
                        MaximumAndMinimumElement();
                        break;
                    case 10:
                        CheckIfElementExists();
                        break;
                    case 11:
                        ClearList();
                        break;
                    case 12:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            Console.WriteLine("Exiting program...");
            Console.ReadKey();
        }

        public static void ListInsertion()
        {
            Console.WriteLine("Enter the element to insert:");
            int element = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the index to insert at:");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index > list.Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            list.Insert(index, element);
            Console.WriteLine($"Element {element} inserted at index {index}");
        }

        public static void ListDeletion()
        {
            Console.WriteLine("Enter the index to delete:");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= list.Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            list.RemoveAt(index);
            Console.WriteLine($"Element at index {index} deleted");
        }

        public static void ListSearch()
        {
            Console.WriteLine("Enter the element to search:");
            int element = int.Parse(Console.ReadLine());

            int index = list.IndexOf(element);
            if (index != -1)
            {
                Console.WriteLine($"Element {element} found at index {index}");
            }
            else
            {
                Console.WriteLine($"Element {element} not found");
            }
        }

        public static void ListTraversal()
        {
            Console.WriteLine("List elements:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void ListUpdate()
        {
            Console.WriteLine("Enter the index to update:");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= list.Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            Console.WriteLine("Enter the new value:");
            int newValue = int.Parse(Console.ReadLine());

            list[index] = newValue;
            Console.WriteLine($"Element at index {index} updated to {newValue}");
        }

        public static void ListDisplay()
        {
            ListTraversal(); // Reusing the traversal method
        }

        public static void ListSorting()
        {
            list.Sort();
            Console.WriteLine("List sorted successfully");
        }

        public static void ListReversal()
        {
            list.Reverse();
            Console.WriteLine("List reversed successfully");
        }

        public static void MaximumAndMinimumElement()
        {
            int max = list.Max();
            int min = list.Min();

            Console.WriteLine($"Maximum Element: {max}");
            Console.WriteLine($"Minimum Element: {min}");
        }

        public static void CheckIfElementExists()
        {
            Console.WriteLine("Enter the element to check:");
            int element = int.Parse(Console.ReadLine());

            if (list.Contains(element))
            {
                Console.WriteLine($"Element {element} exists in the list");
            }
            else
            {
                Console.WriteLine($"Element {element} does not exist in the list");
            }
        }

        public static void ClearList()
        {
            list.Clear();
            Console.WriteLine("List cleared successfully");
        }
    }
}
