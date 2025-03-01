public class Solution {
    public int[] ApplyOperations(int[] nums)
    {
        int[] arr1=new int[nums.Length];
        Array.Fill(arr1,0);
       for(int i=0;i<nums.Length-1;i++)
       {
        if(nums[i]==nums[i+1])
        {
            nums[i]=nums[i]*2;
            nums[i+1]=0;
        }
       }
       int num=0;
       for(int i=0;i<nums.Length;i++)
       {
          if(nums[i]!=0)
          {
            arr1[num]=nums[i];
            num++;
          }
       }
       return arr1;
    }
}