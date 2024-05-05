using System;

namespace DataStructures.SearchingAlgorithms
{
    public class FibonacciSearch : ISearchAlgorithm
    {
        public int Search(int[] array, int target)
        {
            int fibMMinus2 = 0;
            int fibMMinus1 = 1;
            int fibM = fibMMinus1 + fibMMinus2;

            while (fibM < array.Length)
            {
                fibMMinus2 = fibMMinus1;
                fibMMinus1 = fibM;
                fibM = fibMMinus1 + fibMMinus2;
            }

            int offset = -1;

            while (fibM > 1)
            {
                int i = Math.Min(offset + fibMMinus2, array.Length - 1);

                if (array[i] < target)
                {
                    fibM = fibMMinus1;
                    fibMMinus1 = fibMMinus2;
                    fibMMinus2 = fibM - fibMMinus1;
                    offset = i;
                }
                else if (array[i] > target)
                {
                    fibM = fibMMinus2;
                    fibMMinus1 = fibMMinus1 - fibMMinus2;
                    fibMMinus2 = fibM - fibMMinus1;
                }
                else
                {
                    return i;
                }
            }

            if (fibMMinus1 == 1 && array[offset + 1] == target)
            {
                return offset + 1;
            }

            return -1;
        }
    }
}