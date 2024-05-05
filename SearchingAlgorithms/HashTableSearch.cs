using System.Collections.Generic;

namespace DataStructures.SearchingAlgorithms
{
    public class HashTableSearch : ISearchAlgorithm
    {
        public int Search(int[] array, int target)
        {
            var hashTable = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                hashTable[array[i]] = i;
            }

            if (hashTable.ContainsKey(target))
            {
                return hashTable[target];
            }

            return -1; // Target not found
        }
    }
}