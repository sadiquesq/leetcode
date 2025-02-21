public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        StringBuilder st=new StringBuilder();
        for(int i=0;i<words.Count();i++)
        {
            st.Append(words[i][0]);
        }
        return st.ToString()==s;
    }
}