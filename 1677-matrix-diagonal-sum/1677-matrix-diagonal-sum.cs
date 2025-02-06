public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum=0;
        if(mat[0].Length==1)return mat[0][0];
        for(int i=0;i<mat.Length;i++)
        {
            int n=mat.Length-1-i;
            if(i==n)
            {
                sum+=mat[i][n];
            }
            else{
    sum+=mat[i][i];
             sum+=mat[i][mat.Length-1-i];
            }
         
        }
        
        
        return sum;
    }
}