public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
         
        bool IsVowel(char c)
        {
            return "aeiou".Contains(c);
        }

        bool IsValidWord(string word)
        {
            return IsVowel(word[0]) && IsVowel(word[^1]);
        }

        // Precompute the prefix sum of valid words
        int n = words.Length;
        int[] prefixSum = new int[n + 1];
        
        for (int i = 0; i < n; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + (IsValidWord(words[i]) ? 1 : 0);
        }

        int[] results = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            int li = queries[i][0];
            int ri = queries[i][1];
            results[i] = prefixSum[ri + 1] - prefixSum[li];
        }

        return results;
}
}