namespace DataStructures.SearchingAlgorithms
{
    public class LinearSearch : ISearchAlgorithm
    {
        public int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1; // Target not found
        }
    }
}