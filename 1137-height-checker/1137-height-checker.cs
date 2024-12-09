public class Solution {
    public int HeightChecker(int[] heights) {
         List<int> height = heights.OrderBy(h => h).ToList();
 int count = 0;
 for (int i = 0; i < height.Count; i++)
 {
     if (heights[i]!=height[i])
     {
         count++;
     }
 }
 return count;
    }
}