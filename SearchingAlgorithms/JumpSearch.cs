using System;

namespace DataStructures.SearchingAlgorithms
{
    public class JumpSearch : ISearchAlgorithm
    {
        public int Search(int[] array, int target)
        {
            int blockSize = (int)Math.Sqrt(array.Length);
            int i = 0;

            while (i < array.Length && array[i] < target)
            {
                i += blockSize;
            }

            int startPos = Math.Max(i - blockSize, 0);

            for (int j = startPos; j < i; j++)
            {
                if (array[j] == target)
                    return j;
            }

            return -1; // Target not found
        }
    }
}