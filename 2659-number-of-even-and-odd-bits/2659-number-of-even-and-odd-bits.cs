public class Solution {
    public int[] EvenOddBit(int n) {
          int[] Result = new int[2];
  List<int> number = new List<int>();
  string binary =new string(Convert.ToString(n,2).Reverse().ToArray());
  for (int i = 0;i<binary.Length;i++)
  {
      if (binary[i]=='1')
      {
          number.Add(i);
      }
  }
  int even = number.Count(n => n % 2==0);
  int odd = number.Count(n => n % 2 == 1);

  Result[0] = even;
  Result[1] = odd;
  return Result;
    }
}