public class Solution {
    public bool DivideArray(int[] nums) {
            return nums.GroupBy( n => n ).Where( g => g.Count() %2 == 1).Count() > 0 ? false : true;

    }
}