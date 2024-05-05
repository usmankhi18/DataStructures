namespace DataStructures.SearchingAlgorithms
{
    class SublistSearch
    {
        public int Search(int[] arr, int[] sublist)
        {
            int n = arr.Length;
            int m = sublist.Length;

            for (int i = 0; i <= n - m; i++)
            {
                int j;
                for (j = 0; j < m; j++)
                {
                    if (arr[i + j] != sublist[j])
                        break;
                }
                if (j == m)
                    return i; // Sublist found at index i
            }
            return -1; // Sublist not found
        }
    }
}