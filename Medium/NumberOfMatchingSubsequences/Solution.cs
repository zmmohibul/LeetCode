public class Solution {
    public int NumMatchingSubseq(string s, string[] words) {
        var count = 0;
        foreach (var word in words)
        {
            var wi = 0;
            var si = 0;
            while (wi < word.Length && si < s.Length)
            {
                if (word[wi] == s[si])
                {
                    wi++;
                }
                si++;
            }
            if (wi == word.Length) count++;
        }

        return count;
    }
}