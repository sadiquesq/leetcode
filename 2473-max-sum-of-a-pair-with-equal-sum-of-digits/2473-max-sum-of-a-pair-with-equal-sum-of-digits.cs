public class Solution {
    public int MaximumSum(int[] nums) {
          Dictionary<int, int> SumPos = new();
  int iSumDigits = 0, maxSum = -1;

  for (int i = 0; i <= nums.Length - 1; i++)
  {

      iSumDigits = SumDigits(nums[i]);

      if (!SumPos.TryAdd(iSumDigits, nums[i]))
      {
          maxSum = Math.Max(maxSum, nums[i] + SumPos[iSumDigits]);
          SumPos[iSumDigits] = Math.Max(nums[i], SumPos[iSumDigits]);
      }
  }

  return maxSum;
    }
     private int SumDigits(int number)
 {
     int sum = 0;
     while (number != 0)
     {
         sum += number % 10;
         number /= 10;
     }
     return sum;
 }
}