public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
          int[] result = new int[2];
  for (int i = 0; i < numbers.Length; i++)
  {
      for (int j = i+1;j < numbers.Length; j++)
      {
          if (numbers[i] +numbers[j] == target)
          {
              result[0] = i+1;
              result[1] = j+1;
              break;
          }
      }
  }
  return result;
    }
}