public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int count=0;
        int i=1;
        while(count<k)
        {
            if(!arr.Contains(i))
            {
                count++;
            }
            i++;
        }
        return i-1;
    }
}