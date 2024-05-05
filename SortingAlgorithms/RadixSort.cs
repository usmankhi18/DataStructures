namespace DataStructures.SortingAlgorithms
{
    public class RadixSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            int max = GetMax(array);
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(array, array.Length, exp);
            }
        }

        private void CountSort(int[] array, int n, int exp)
        {
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                count[(array[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }

        private int GetMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}