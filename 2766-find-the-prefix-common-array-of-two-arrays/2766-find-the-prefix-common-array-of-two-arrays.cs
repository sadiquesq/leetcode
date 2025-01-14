public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
      int[] result = new int[A.Length];
 for (int i = 0; i < A.Length; i++)
 {
     int count = 0;
     var sub1=A.Take(i+1).ToArray();
     var sub2 = B.Take(i+1).ToArray();
     for (int j = 0; j < sub1.Length; j++)
     {
         if (Array.Exists(sub1, e => e == sub2[j]))
         {
             count++;
         }
     }

     result[i] = count;
 }
 return result;
    }
}