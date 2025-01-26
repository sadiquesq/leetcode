public class Solution {
    public bool CheckIfPangram(string sentence) {
        
        string result =new string(sentence.Distinct().ToArray());
        return result.Length==26;
    }
}