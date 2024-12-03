public class Solution {
    public string AddSpaces(string s, int[] spaces) {
         StringBuilder spacedString = new StringBuilder();
 int index = 0;
 for (int i = 0;i<spaces.Length;i++)
 {
     int length = spaces[i] - index;
     string sub = s.Substring(index,length);
     spacedString.Append(sub);
     spacedString.Append(' ');
     index = spaces[i];
 }

 int len = s.Length - spaces[spaces.Length - 1];
 string sub1 = s.Substring(spaces[spaces.Length - 1],len);
 spacedString.Append(sub1);

 string main =spacedString.ToString();
 return main ;
    }
}