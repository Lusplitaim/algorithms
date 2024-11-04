namespace Algorithms.Search
{
    internal static class SearchingExtensions
    {
        /*
         * Best Case: O(1)
         * Average Case: O(log N)
         * Worst Case: O(log N)
         */
        public static int? BinarySearch(this int[] arr, int val)
        {
            int startIdx = 0;
            int endIdx = arr.Length - 1;
            while (startIdx <= endIdx)
            {
                int midIdx = startIdx + (endIdx - startIdx) / 2;
                int mid = arr[midIdx];

                if (mid == val)
                {
                    return midIdx;
                }

                if (val > mid)
                {
                    startIdx = midIdx + 1;
                }
                else
                {
                    endIdx = midIdx - 1;
                }
            }

            return null;
        }

        /*
         * Worst case: O(log3N)
         * Average case: Θ(log3N)
         * Best case: Ω(1)
         */
        public static int? TernarySearch(this int[] arr, int val)
        {
            int startIdx = 0;
            int endIdx = arr.Length - 1;
            while (startIdx <= endIdx)
            {
                int mid1Idx = startIdx + (endIdx - startIdx) / 3;
                int mid1 = arr[mid1Idx];
                int mid2Idx = endIdx - (endIdx - startIdx) / 3;
                int mid2 = arr[mid2Idx];

                if (mid1 == val)
                {
                    return mid1Idx;
                }
                if (mid2 == val)
                {
                    return mid2Idx;
                }

                if (val < mid1)
                {
                    endIdx = mid1Idx - 1;
                }
                else if (val > mid2)
                {
                    startIdx = mid2Idx + 1;
                }
                else
                {
                    startIdx = mid1Idx + 1;
                    endIdx = mid2Idx - 1;
                }
            }

            return null;
        }
    }
}
