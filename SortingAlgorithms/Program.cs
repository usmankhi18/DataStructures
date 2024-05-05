using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SortingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, n - 1);
            }

            Stopwatch sw = new Stopwatch();

            ISortAlgorithm[] sortAlgorithms = new ISortAlgorithm[]
            {
            new BubbleSort(),
            new InsertionSort(),
            new SelectionSort(),
            new MergeSort(),
            new ShellSort(),
            new HeapSort(),
            new BucketSort(),
            new CountingSort(),
            new RadixSort(),
            new QuickSort()
            };

            foreach (var algorithm in sortAlgorithms)
            {
                int[] sortedArray = new int[array.Length];
                Array.Copy(array, sortedArray, array.Length);
                Console.WriteLine($"Sorting using {algorithm.GetType().Name}:");
                sw.Start();
                algorithm.Sort(sortedArray);
                sw.Stop();
                Console.WriteLine($"{algorithm.GetType().Name} Time: {sw.Elapsed}");
                sw.Reset();
                PrintArray(sortedArray);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
