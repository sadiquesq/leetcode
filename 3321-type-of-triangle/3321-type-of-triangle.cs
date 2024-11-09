public class Solution {
    public string TriangleType(int[] nums) {
        Array.Sort(nums);
        if(nums[0]+nums[1]<=nums[2])
        {
            return "none";
        }
        int[] unique=nums.Distinct().ToArray();

        if(unique.Length==3)
        {
            return "scalene";
        }
        else if(unique.Length==2)
        {
            return "isosceles";
        }
        else{
              return "equilateral";
        }
         
    }
}