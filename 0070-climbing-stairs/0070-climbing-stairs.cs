public class Solution {
    public int ClimbStairs(int n) {
      if(n==1)
      {
        return 1;
      }
      int x =1;
      int y=2;
      int count=y;
      for(int i=3;i<=n;i++)
      {
        count= x+y;
        x=y;
        y=count;
      }
      return count;
    }
}