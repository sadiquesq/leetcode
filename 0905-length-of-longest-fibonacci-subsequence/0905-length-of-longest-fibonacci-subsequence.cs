public class Solution {
    public int LenLongestFibSubseq(int[] arr) {
        int len=0;
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
              List<int> ls=new List<int>();
              int a=arr[i];
              int b=arr[j];
               while(arr.Contains(a+b))
               {
                 
                 ls.Add(a+b);
                 int tem=a;
                 a=b;
                 b=tem+b;
               }  
               if(ls.Count()>0 && ls.Count()>len)
               {
                   len=ls.Count();
               }
            }
        }
        if(len>0) return len+2;
        return 0;
    }
}