public class Solution {
    public string StringHash(string s, int k) 
    {
        string a="";
        int num=0;
        for(int i=0;i<s.Length;i++)
        {
            char b=s[i];
            int c=(int)b;
            int d=c-97;
            num +=d;
            int asl=0;
            if((i+1)%k==0)
            {
               
                
                asl = num%26;
                asl=asl+97;
            
               
                char p=(char)asl;
                a+=p;
                num=0;
                d=0;
            
            }
        }

      return a;
    
    }
}