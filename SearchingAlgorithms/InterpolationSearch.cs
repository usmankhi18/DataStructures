using System.Collections.Generic;
using System;

namespace DataStructures.SearchingAlgorithms
{
    public class InterpolationSearch : ISearchAlgorithm
    {
        public int Search(int[] array, int target)
        {
            int lo = 0;
            int hi = array.Length - 1;
            int mid = -1;
            int comparisons = 1;
            int index = -1;

            while (lo <= hi)
            {
                comparisons++;

                long arraylow = array[lo];
                long arrayhigh = array[hi];

                // Probe the mid point
                long b = (arrayhigh - arraylow);

                // Calculating the difference between high and low
                long d = (hi - lo);

                // Calculating the difference between target and arraylow
                long e = (long.Parse(target.ToString()) - arraylow);

                // Calculating the product of (high - low) and (target - arraylow)
                long c = (d * e);

                // Calculating the division of the product by (arrayhigh - arraylow)
                long a = (c / b);

                // Calculating the midpoint
                long midi = lo + a;
                //long midi = lo + (((hi - lo) * (target - array[lo])) / (array[hi] - array[lo]));
                mid = int.Parse(midi.ToString());

                // Data found
                if (array[mid] == target)
                {
                    index = mid;
                    break;
                }
                else
                {
                    if (array[mid] < target)
                    {
                        // If data is larger, data is in upper half
                        lo = mid + 1;
                    }
                    else
                    {
                        // If data is smaller, data is in lower half
                        hi = mid - 1;
                    }
                }
            }
            return index;
        }
    }
}