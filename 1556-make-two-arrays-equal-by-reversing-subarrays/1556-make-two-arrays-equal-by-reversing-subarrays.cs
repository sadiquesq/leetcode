public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
         Array.Sort(target);
        Array.Sort(arr);
        var len = target.Length;
        for(var i = 0; i < len; i++){
            if(target[i] != arr[i])
                return false;
        }
        return true;
    }
}