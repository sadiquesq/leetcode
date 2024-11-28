public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
         string a = x.ToString();
  // string a=convert.ToString(x);
  int b = 0;
  for (int i = 0; i < a.Length; i++)
  {
      string d=Convert.ToString(a[i]);
      int m = Convert.ToInt32(d);
      b += m;
  }
  if (x % b == 0)
  {
      return b;
  }
  return -1;
    }
}