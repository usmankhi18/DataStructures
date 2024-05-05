using System;

namespace DataStructures.SortingAlgorithms
{

    public class MergeSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            MergeSortRecursive(array, 0, array.Length - 1);
        }

        private void MergeSortRecursive(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSortRecursive(array, left, mid);
                MergeSortRecursive(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(array, left, L, 0, n1);
            Array.Copy(array, mid + 1, R, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
    }
}