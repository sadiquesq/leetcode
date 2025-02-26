public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
            int maxSum = 0, minSum = 0, currMax = 0, currMin = 0;

        foreach (int num in nums) {
            currMax = Math.Max(0, currMax + num);
            currMin = Math.Min(0, currMin + num);
            maxSum = Math.Max(maxSum, currMax);
            minSum = Math.Min(minSum, currMin);
        }

        return Math.Max(maxSum, Math.Abs(minSum));
    }
}