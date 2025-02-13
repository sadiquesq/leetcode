public class Solution {
    public int MinOperations(int[] nums, int k) {
    
        var count = 0;
        var queue = new PriorityQueue<long, long>();

        foreach (var item in nums) queue.Enqueue(item, item);

        while (queue.Count > 1 && queue.Peek() < k) {

            var temp = queue.Dequeue() * 2 + queue.Dequeue();
            queue.Enqueue(temp, temp);
            count++;
        }
        return count;
    }
}