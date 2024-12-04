public class Solution {
    public bool IsBalanced(string num) {
           int even = 0;
   int odd = 0;

   for (int i = 0; i < num.Length; i++)
   {
       string b=Convert.ToString(num[i]);
       int a = Convert.ToInt32(b);
       if(i%2==0)
       {
           even += a;
       }
       else
       {
           odd += a;
       }
   }
           
   return even==odd;
    }
}