public class Solution {
    public int MinElement(int[] nums) {
          for (int i = 0; i < nums.Length; i++)
  {
      string n = nums[i].ToString();
      int x = 0;
      for (int j = 0; j < n.Length; j++)
      {
          string a = n[j].ToString();
           x += Convert.ToInt32(a);
    
      }
      nums[i] = x;
  }
  return nums.Min();
    }
}