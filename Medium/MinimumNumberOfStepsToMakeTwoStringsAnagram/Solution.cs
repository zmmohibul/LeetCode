namespace MinimumNumberOfStepsToMakeTwoStringsAnagram;

public class Solution
{
    public int MinSteps(string s, string t)
    {
        var sLetterFreq = new Dictionary<char, int>();
        var tLetterFreq = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            sLetterFreq[s[i]] = sLetterFreq.GetValueOrDefault(s[i], 0) + 1;
            tLetterFreq[t[i]] = tLetterFreq.GetValueOrDefault(t[i], 0) + 1;
        }

        var moves = 0;
        foreach (var (letter, count) in sLetterFreq)
        {
            if (tLetterFreq.ContainsKey(letter))
            {
                if ((count > tLetterFreq[letter]))
                {
                    moves += (count - tLetterFreq[letter]);
                }
            }
            else
            {
                moves += count;
            }
        }

        return moves;
    }
}