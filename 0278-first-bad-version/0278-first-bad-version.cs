/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n)
     {
      var left = 1;
        var right = n;

        while (left <= right) {
            var mid = left + (right - left) / 2;

            if (IsBadVersion(mid))
                right = mid - 1;
            else
                left = mid + 1;
        }

        return left;
    }
}