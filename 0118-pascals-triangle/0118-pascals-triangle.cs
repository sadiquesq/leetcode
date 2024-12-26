public class Solution {
    public IList<IList<int>> Generate(int numRows) {
         IList<IList<int>> Main = new List<IList<int>>();

 int LRow = 0;
 for (int i = 0; i < numRows; i++)
 {
     IList<int> sub = new List<int>();
     sub.Add(1);

     if(Main.Count>0)
     {
         LRow = i - 1;
         for (int j = 1; j < i; j++)
         {
             sub.Add(Main[LRow][j - 1] + Main[LRow][j]);
         }
         sub.Add(1);
     }
     Main.Add(sub);

 }
 return Main;
    }
}