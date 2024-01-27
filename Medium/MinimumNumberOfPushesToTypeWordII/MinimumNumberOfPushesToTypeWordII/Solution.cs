namespace MinimumNumberOfPushesToTypeWordII;

public class Solution {
    public int MinimumPushes(string word) {
        var freq = new Dictionary<char, int>();
        foreach (var c in word) {
            freq[c] = freq.GetValueOrDefault(c) + 1;
        }

        freq = freq.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        var level = 1;
        var remCount = 0;
        var ans = 0;
        while (freq.Count > 0) {
            var ch = freq.First().Key;
            var chCount = freq.First().Value;
            ans += (chCount * level);
            
            freq.Remove(ch);
            remCount++;

            if (remCount % 8 == 0) {
                level++;
            }
        }

        return ans;
    }
}