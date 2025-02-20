public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        Array.Sort(nums);
        int len=nums.Length;
        for(int i=0;i<nums.Length;i++)
        {
            int a=Convert.ToInt32(nums[i],2);
            if(a!=i)
            {
                return Convert.ToString(i,2).PadLeft(len,'0');
            }
        }
        return Convert.ToString((nums.Length),2).PadLeft(len,'0');
    }
}