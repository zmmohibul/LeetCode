namespace FindAllAnagramsInString;

public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var pCharFreq = new Dictionary<char, int>();
        for (int i = 0; i < p.Length; i++)
        {
            pCharFreq[p[i]] = pCharFreq.GetValueOrDefault(p[i], 0) + 1;
        }

        var result = new List<int>();
        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            var sCharFreq = new Dictionary<char, int>();
            var isAnagram = true;
            for (int j = i; j < i + p.Length; j++)
            {
                if (!pCharFreq.ContainsKey(s[j]))
                {
                    isAnagram = false;
                    break;
                }
                sCharFreq[s[j]] = sCharFreq.GetValueOrDefault(s[j], 0) + 1;
            }

            if (!isAnagram)
            {
                continue;
            }

            for (int j = 0; j < pCharFreq.Count; j++)
            {
                var pItem = pCharFreq.ElementAt(j);
                if (!sCharFreq.ContainsKey(pItem.Key) || pItem.Value != sCharFreq[pItem.Key])
                {
                    isAnagram = false;
                    break;
                }
            }

            if (isAnagram)
            {
                result.Add(i);
            }
        }

        return result;
    }
}