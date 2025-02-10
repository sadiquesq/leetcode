public class Solution {
    public string ClearDigits(string s) {
        StringBuilder sb=new StringBuilder();
        for(int i=0;i<s.Length;i++)
        {
            if(char.IsDigit(s[i]))
            {
                if(sb.Length>0)
                {
                sb.Remove(sb.Length-1,1);
                }
            }
            else{
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }
}