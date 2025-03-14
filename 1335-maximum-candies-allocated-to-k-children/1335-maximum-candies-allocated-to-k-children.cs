public class Solution {
    public int MaximumCandies(int[] candies, long k) {  
       long totalCandies = candies.Sum(c => (long)c); // Use long to prevent overflow

        if (totalCandies < k) return 0; // Not enough candies

        long left = 1, right = Math.Min(totalCandies / k, candies.Max()); // Optimized upper bound

        while (left <= right)
        {
            long mid = left + (right - left) / 2;
            long count = 0;

            foreach (var candy in candies)
            {
                count += candy / mid; 
                if (count >= k) break; // Stop early if k is already reached
            }

            if (count >= k) // If we can distribute at least k pieces, try for a larger size
                left = mid + 1;
            else
                right = mid - 1;
        }

        return (int)right;
    }
}