using System;

namespace DataStructures.SearchingAlgorithms
{
    public class ExponentialSearch : ISearchAlgorithm
    {
        public int Search(int[] array, int target)
        {
            int bound = 1;

            while (bound < array.Length && array[bound] < target)
            {
                bound *= 2;
            }

            int left = bound / 2;
            int right = Math.Min(bound, array.Length - 1);

            return BinarySearch(array, target, left, right);
        }

        public int BinarySearch(int[] arr, int low, int high, int key)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] < key)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }
    }
}