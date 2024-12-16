public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
       for (int i = 0; i < k; i++)
  {
      int n = nums.Min();
      int replace =n*multiplier;
      int indexnum=Array.IndexOf(nums,n);
      nums[indexnum] = replace;
  }
  return nums;
    }
}