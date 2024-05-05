﻿namespace DataStructures.SortingAlgorithms
{
    public class HeapSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            int n = array.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // call max heapify on the reduced heap
                Heapify(array, i, 0);
            }
        }

        void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && array[l] > array[largest])
            {
                largest = l;
            }

            // If right child is larger than largest so far
            if (r < n && array[r] > array[largest])
            {
                largest = r;
            }

            // If largest is not root
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                // Recursively heapify the affected sub-tree
                Heapify(array, n, largest);
            }
        }
    }
}