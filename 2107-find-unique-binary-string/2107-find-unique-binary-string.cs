public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
     
        int len=nums.Length;
        for(int i=0;i<nums.Length;i++)
        {
          string a=Convert.ToString(i,2).PadLeft(len,'0');
          if(!nums.Contains(a))
          {
            return a;
          }
        }
        return Convert.ToString((nums.Length),2).PadLeft(len,'0');
    }
}