public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        List<int> ls=new List<int>();
        for(int i=0;i<index.Length;i++)
        {
         ls.Insert(index[i],nums[i]);
        }
        return ls.ToArray();
    }
}