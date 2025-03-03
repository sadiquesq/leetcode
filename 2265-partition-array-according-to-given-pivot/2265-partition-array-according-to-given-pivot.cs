public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int[] result=new int[nums.Length];
        int a=0;
        if(nums.Any(n=>n<pivot))
        {
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]<pivot)
            {
                result[a]=nums[i];
                a++;
            }
        }
        }
        if(0<nums.Count(n=>n==pivot))
        {
            for(int i=0;i<nums.Count(n=>n==pivot);i++)
            {
                result[a]=pivot;
                a++;
            }
        }
         if(nums.Any(n=>n>pivot))
        {
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]>pivot)
            {
                result[a]=nums[i];
                a++;
            }
        }
        }
       return result;
    }
}