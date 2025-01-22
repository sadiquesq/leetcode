public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int total=0;
        for(int i=0;i<jewels.Length;i++)
        {
            total+=stones.Count(e=>e==jewels[i]);

        }
        return total;
    }
}