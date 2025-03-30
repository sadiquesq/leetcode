public class Solution {
    public bool UniqueOccurrences(int[] arr) {
         var freq = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            freq[num] = freq.GetValueOrDefault(num) + 1;
        }

        var set = new HashSet<int>();
        foreach (var count in freq.Values)
        {
            if (set.Contains(count))
            {
                return false;
            }

            set.Add(count);
        }

        return true;
    }
    }
