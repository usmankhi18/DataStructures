using System;
using System.Linq;

namespace DataStructures.Arrays
{
    internal class Program
    {
        static int[] arr;

        static void Main(string[] args)
        {
            bool exit = false;

            
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            arr = new int[size];

            Console.WriteLine("Enter elements for the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element at index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            while (!exit)
            {
                Console.WriteLine("Array Operations:");
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
                Console.WriteLine("11. Clear Array");
                Console.WriteLine("12. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ArrayInsertion();
                        break;
                    case 2:
                        ArrayDeletion();
                        break;
                    case 3:
                        ArraySearch();
                        break;
                    case 4:
                        ArrayTraversal();
                        break;
                    case 5:
                        ArrayUpdate();
                        break;
                    case 6:
                        ArrayDisplay();
                        break;
                    case 7:
                        ArraySorting();
                        break;
                    case 8:
                        ArrayReversal();
                        break;
                    case 9:
                        MaximumAndMinimumElement();
                        break;
                    case 10:
                        CheckIfElementExists();
                        break;
                    case 11:
                        ClearArray();
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

        public static void ArrayInsertion()
        {
            Console.WriteLine("Enter the element to insert:");
            int element = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the index to insert at:");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            arr[index] = element;
            Console.WriteLine($"Element {element} inserted at index {index}");
        }

        public static void ArrayDeletion()
        {
            Console.WriteLine("Enter the index to delete:");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[arr.Length - 1] = 0; // Assuming the default value is 0
            Console.WriteLine($"Element at index {index} deleted");
        }

        public static void ArraySearch()
        {
            Console.WriteLine("Enter the element to search:");
            int element = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(arr, element);
            if (index != -1)
            {
                Console.WriteLine($"Element {element} found at index {index}");
            }
            else
            {
                Console.WriteLine($"Element {element} not found");
            }
        }

        public static void ArrayTraversal()
        {
            Console.WriteLine("Array elements:");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void ArrayUpdate()
        {
            Console.WriteLine("Enter the index to update:");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            Console.WriteLine("Enter the new value:");
            int newValue = int.Parse(Console.ReadLine());

            arr[index] = newValue;
            Console.WriteLine($"Element at index {index} updated to {newValue}");
        }

        public static void ArrayDisplay()
        {
            ArrayTraversal(); // Reusing the traversal method
        }

        public static void ArraySorting()
        {
            Array.Sort(arr);
            Console.WriteLine("Array sorted successfully");
        }

        public static void ArrayReversal()
        {
            Array.Reverse(arr);
            Console.WriteLine("Array reversed successfully");
        }

        public static void MaximumAndMinimumElement()
        {
            int max = arr.Max();
            int min = arr.Min();

            Console.WriteLine($"Maximum Element: {max}");
            Console.WriteLine($"Minimum Element: {min}");
        }

        public static void CheckIfElementExists()
        {
            Console.WriteLine("Enter the element to check:");
            int element = int.Parse(Console.ReadLine());

            if (arr.Contains(element))
            {
                Console.WriteLine($"Element {element} exists in the array");
            }
            else
            {
                Console.WriteLine($"Element {element} does not exist in the array");
            }
        }

        public static void ClearArray()
        {
            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("Array cleared successfully");
        }
    }
}
