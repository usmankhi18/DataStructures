namespace DataStructures.SortingAlgorithms
{
    public class CountingSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            int n = array.Length;

            int max = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int[] count = new int[max + 1];
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                count[array[i]]++;
            }

            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                count[array[i]]--;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }
    }
}