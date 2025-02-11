public class Solution {
    public string RemoveOccurrences(string s, string part) {
        
        while(s.IndexOf(part) !=-1)
        {
            s=s.Remove(s.IndexOf(part),part.Length);
        }
        return s;
    }
}