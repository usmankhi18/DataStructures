using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SearchingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10000000;
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, n - 1);
            }
            Array.Sort(array); // Make sure array is sorted

            int target = array[rand.Next(0, n-1)]; // Pick a random element as target

            int[] sublist = { array[rand.Next(0, n-1)], array[rand.Next(0, n - 1)] }; // Pick a random sublist

            Stopwatch sw = new Stopwatch();

            var searchAlgorithms = new List<ISearchAlgorithm>{
                                                new LinearSearch(),
                                                new BinarySearch(),
                                                new InterpolationSearch(),
                                                new JumpSearch(),
                                                new HashTableSearch(),
                                                new ExponentialSearch(),
                                                new FibonacciSearch(),
                                    };

            foreach (var algorithm in searchAlgorithms)
            {
                sw.Start();
                int result = algorithm.Search(array, target);
                sw.Stop();
                Console.WriteLine($"{algorithm.GetType().Name} Result: {result}");
                Console.WriteLine($"{algorithm.GetType().Name} Time: {sw.Elapsed}");
                sw.Reset();
            }
            var sublistSearch = new SublistSearch();
            sw.Start();
            int sublistResult = sublistSearch.Search(array, sublist);
            sw.Stop();
            Console.WriteLine($"Sublist Search Result: {sublistResult}");
            Console.WriteLine($"Sublist Search Time: {sw.Elapsed}");
            Console.ReadKey();
        }
    }
}
