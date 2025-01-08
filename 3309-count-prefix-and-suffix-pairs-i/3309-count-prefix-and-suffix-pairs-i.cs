public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        

  int count = 0;  
 for (int i = 0; i < words.Length-1; i++)
 {
     for (int j = i + 1; j < words.Length; j++)
     {
         if (words[j].Contains(words[i]))
         {
             if(words[j].EndsWith(words[i]) && words[j].StartsWith(words[i]))
             {
                 count++;
             }
         }
     }
 }
 return count;
    }
}