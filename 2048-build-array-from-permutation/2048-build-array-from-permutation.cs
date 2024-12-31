public class Solution {
    public int[] BuildArray(int[] nums) {
        
 int[] output = new int[nums.Length];
 for (int i = 0; i < nums.Length; i++)
 {
     output[i] = nums[nums[i]];
 }
 for (int i = 0;i < output.Length; i++)
 {
     Console.WriteLine(output[i]);
 }
 return output;



    }
}