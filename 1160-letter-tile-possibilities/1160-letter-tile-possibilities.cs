public class Solution {
    public int NumTilePossibilities(string tiles) {
        
       HashSet<string> uniquePermutations = new HashSet<string>();

        GeneratePermutationsOfCombinations(tiles, "", 0, uniquePermutations);
      
      return uniquePermutations.Count();

    }

     static void GeneratePermutationsOfCombinations(string input, string output, int index, HashSet<string> uniquePermutations)
    {
        if (index == input.Length)
        {
            if (!string.IsNullOrEmpty(output))
            {
                GeneratePermutations(output.ToCharArray(), 0, uniquePermutations);
            }
            return;
        }

        GeneratePermutationsOfCombinations(input, output + input[index], index + 1, uniquePermutations);

        GeneratePermutationsOfCombinations(input, output, index + 1, uniquePermutations);
    }

    static void GeneratePermutations(char[] chars, int index, HashSet<string> uniquePermutations)
    {
        if (index == chars.Length - 1)
        {
            uniquePermutations.Add(new string(chars));
            return;
        }

        HashSet<char> swapped = new HashSet<char>();
        for (int i = index; i < chars.Length; i++)
        {
            if (swapped.Contains(chars[i])) continue; 
            swapped.Add(chars[i]);

            Swap(chars, index, i);
            GeneratePermutations(chars, index + 1, uniquePermutations);
            Swap(chars, index, i); 
        }
    }

    static void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}