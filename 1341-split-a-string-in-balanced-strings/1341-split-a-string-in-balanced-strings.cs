public class Solution {
    public int BalancedStringSplit(string s) {
        int r=0;
        int l=0;
        int count=0;
        string result="";
        for(int i=0;i<s.Length;i++)
        {
            result+=s[i];
            r=result.Count(e=>e=='R');
             l=result.Count(e=>e=='L');
            if(r==l && r>0)
            {
                count++;
                result="";
            }
        }
        return count;
    }
}