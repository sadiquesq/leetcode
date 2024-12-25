public class Solution {
    public string SortVowels(string s) {
          string Vowels = "AEIOUaeiou";

  List<char> stringVowels= new List<char>();

  for (int i = 0; i < s.Length; i++)
  {
      if(Vowels.Contains(s[i]))
      {

          stringVowels.Add(s[i]);
      }
  }
  stringVowels.Sort();

  char[] chars=s.ToCharArray();
  int x = 0;
  for (int i = 0; i < s.Length; i++)
  {
      if (Vowels.Contains(chars[i]))
      {
          chars[i] = stringVowels[x];
          x++;
      }
  }

  return string.Join("", chars);
    }
}