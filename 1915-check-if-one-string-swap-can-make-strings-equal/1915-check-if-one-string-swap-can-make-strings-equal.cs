public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if(s1==s2) return true;
        int count=0;
        char[] arr1=s1.ToCharArray();
        char[] arr2=s2.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        if(!arr1.SequenceEqual(arr2))return false;
        for(int i=0;i<s1.Length;i++)
        {
            if(s1[i]==s2[i])
            {
                count++;
            }
        }
        return (s1.Length-2)==count;
    }
}