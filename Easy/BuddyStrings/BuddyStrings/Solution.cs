namespace BuddyStrings;

public class Solution {
    public bool BuddyStrings(string s, string goal) {
        if (s.Length != goal.Length)
        {
            return false;
        }
        
        var mismatch = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != goal[i])
            {
                mismatch++;
            }

            if (mismatch > 2)
            {
                return false;
            }
        }

        var sLetterFreq = new Dictionary<char, int>();
        var goalLetterFreq = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            sLetterFreq[s[i]] = sLetterFreq.GetValueOrDefault(s[i], 0) + 1;
            goalLetterFreq[goal[i]] = goalLetterFreq.GetValueOrDefault(goal[i], 0) + 1;
        }

        if (sLetterFreq.Count != goalLetterFreq.Count)
        {
            return false;
        }

        var repeatingChar = false;
        foreach (var (ch, count) in sLetterFreq)
        {
            if (!goalLetterFreq.ContainsKey(ch) || goalLetterFreq[ch] != count)
            {
                return false;
            }

            if (count > 1)
            {
                repeatingChar = true;
            }
        }

        if (repeatingChar)
        {
            return true;
        }

        if (mismatch < 2)
        {
            return false;
        }

        return true;
    }
}