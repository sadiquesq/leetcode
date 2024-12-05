public class Solution {
    public int PivotInteger(int n) {
            int a = 1;
    for (int i = 1; i <= n; i++)
    {
        int left = 0;
        int right = 0;
        for (int j = 1; j <= a; j++)
        {
            left += j;
        }
        for (int k = a; k <=n; k++)
        {
            right += k;
        }


        if (left == right) 
        {
            return a;
        }
        a++;
    }
    return -1;
    }
}