public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string st="";
        for(int i=0;i<s.Length/2;i++)
        {
         st+=s[i];
         string a=st;
         while(a.Length<s.Length)
         {
            a+=st;
            if(a==s)return true;
         }
        }
        return false;
    }
}