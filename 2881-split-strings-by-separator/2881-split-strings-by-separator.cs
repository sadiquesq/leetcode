public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {


      List<string> split1 = new List<string>();
  for (int i = 0; i < words.Count; i++)
  {
      string[] result = words[i].Split(separator);
      for (int j = 0; j < result.Length; j++)
      {
          split1.Add(result[j]);
      }
  }
 

  List<string> split2 = new List<string>();
  for (int i = 0; i < split1.Count; i++)
  {
      if (split1[i].Length > 0)
      {
          split2.Add(split1[i]);
      }
  }
  return split2;
    }
}