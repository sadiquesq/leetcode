public class Solution {
    public int MaxAscendingSum(int[] nums)
     {
        List<int> ls=new List<int>();
        int sum=nums[0];
        for(int i=1;i<nums.Length;i++)
        {
              if(nums[i]<=nums[i-1])
              {
                ls.Add(sum);
                sum=0;
              }
                sum+=nums[i];
        }
       ls.Add(sum);
       return ls.Max();
    }
}