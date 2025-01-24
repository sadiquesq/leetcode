public class Solution {
    public string ReverseVowels(string s) {
        char[] vowels={'a','e','i','o','u'};
        char[] main=s.ToCharArray();
        List<char> result =new List<char>();
        for(int i=0;i<s.Length;i++)
        {
            if(vowels.Contains( char.ToLower(s[i])))
            {
                result.Add(s[i]);
            }
        }
        int count=0;
          for(int i=0;i<s.Length;i++)
        {
            if(vowels.Contains( char.ToLower(s[i])))
            {
                main[i]=result[result.Count()-count-1];
                count++;
            }
        } 
      string result1 =new String(main);
      return result1;
    }
}