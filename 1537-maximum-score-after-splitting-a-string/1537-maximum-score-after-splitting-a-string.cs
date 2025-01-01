public class Solution {
    public int MaxScore(string s) {
         int[] results = new int[s.Length-1];
 char zero = '0';
 char one ='1';
 for (int i = 1; i < s.Length; i++) 
 {
     int left = 0;
     int right = 0;
     string rigthx=s.Substring(i);
     string revercse = new string(s.Reverse().ToArray());
     string leftx=revercse.Substring(s.Length-i);
     left=leftx.Count(e=>e==zero);
     right=rigthx.Count(e=>e==one);
     results[i-1] = left+right;
 }
 return results.Max();
    }
}