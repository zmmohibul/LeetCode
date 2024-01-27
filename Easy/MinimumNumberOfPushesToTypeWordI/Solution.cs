namespace MinimumNumberOfPushesToTypeWordI;

public class Solution {
    public int MinimumPushes(string word) {
        var ans = 0;
        var n = word.Length;
        var level = 1;

        while (n > 0) {
            if (n > 8) {
                ans += (level * 8);
            } else {
                ans += (level * n);
            }

            level++;
            n -= 8;
        }
        
        return ans;
    }
}