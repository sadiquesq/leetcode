public class Solution {
    public int MaximumCount(int[] nums) {
        
        int pos=0;
        int neg=0;
        foreach(int num in nums)
        {
          if(num>0) pos++;
          if(num<0) neg++;
        }
        if(pos>neg) return pos;
        if(neg>pos) return neg;
        else return pos;
    }
}