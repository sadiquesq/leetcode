public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        

  int count = 0;
  for (int i = 0; i < words.Length; i++)
  {

      int a = 0; 
      for (int j = 0; j < words[i].Length; j++)
      {
          if (allowed.Contains(words[i][j]))
          {
              a++;
          }
          else
          {
              break;
          }
      }
      if (a == words[i].Length)
      {
          count++;
      }

  }
  return count;


    }
}