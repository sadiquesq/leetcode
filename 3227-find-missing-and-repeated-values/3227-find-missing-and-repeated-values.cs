public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
         int n = grid.Length;
        int totalNumbers = n * n;
        int expectedSum = (totalNumbers + 1) * totalNumbers/ 2;
        int actualSum = 0;
        HashSet<int> seen = new HashSet<int>();
        int duplicate = -1;
        foreach (var row in grid)
        {
            foreach (var num in row)
            {
                actualSum += num;
                if (!seen.Add(num))
                {
                    duplicate = num;
                }
            }
        }
        int missing = expectedSum - (actualSum - duplicate);
        return new int[] { duplicate, missing };
    }
}