using System.Collections.Generic;

namespace DataStructures.SortingAlgorithms
{
    public class BucketSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            int n = array.Length;
            if (n == 0) return;

            // Find minimum and maximum values in the array
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                }
                else if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }

            // Create buckets
            int bucketCount = (maxVal - minVal) / n + 1;
            List<List<int>> buckets = new List<List<int>>();
            for (int i = 0; i < bucketCount; i++)
            {
                buckets.Add(new List<int>());
            }

            // Add elements to buckets
            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (array[i] - minVal) / n;
                buckets[bucketIndex].Add(array[i]);
            }

            // Sort individual buckets
            int index = 0;
            foreach (var bucket in buckets)
            {
                bucket.Sort();
                foreach (var item in bucket)
                {
                    array[index++] = item;
                }
            }
        }
    }
}