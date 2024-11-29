public class Solution {
    public int Maximum69Number (int num) {
          string n=num.ToString();
    if(!n.Contains("6"))
    {
        return num;
    }
    for(int i=0;i<n.Length;i++)
    {
        string a=Convert.ToString(n[i]);
        int res=Convert.ToInt32(a);
        if(res==6)
        {
           char[] nums=n.ToCharArray();
           nums[i]='9';
           string joined =string.Join("",nums);
           int c=Convert.ToInt32(joined);
           return c;

        }

    }
    return num;
    }
}