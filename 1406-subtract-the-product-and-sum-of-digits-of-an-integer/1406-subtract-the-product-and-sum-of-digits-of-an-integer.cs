public class Solution {
    public int SubtractProductAndSum(int n) {
          string num = n.ToString();
   int product = 1;
   int digits = 0;
   for (int i = 0; i < num.Length; i++)
   {
           string b = num[i].ToString();
           int a=int.Parse(b);
       product *= a;
       digits += a;
           
   }
                 return product - digits;
    }
}