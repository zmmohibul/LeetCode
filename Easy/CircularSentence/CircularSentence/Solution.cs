using System.Text;

namespace CircularSentence;

public class Solution {
    public bool IsCircularSentence(string sentence) {
        var words = BuildWordList(sentence);
        for (int i = 0; i < words.Count - 1; i++)
        {
            var word = words[i];
            var nextWord = words[i + 1];

            if (word[word.Length - 1] != nextWord[0])
            {
                return false;
            }
        }

        var first = words[0];
        var last = words[words.Count - 1];

        if (last[last.Length - 1] != first[0])
        {
            return false;
        }

        return true;
    }

    public List<string> BuildWordList(string sentence)
    {
        var list = new List<string>();
        var sb = new StringBuilder();
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                list.Add(sb.ToString());
                sb = new StringBuilder();
            }
            else
            {
                sb.Append(sentence[i]);
            }
        }

        if (sb.Length > 0)
        {
            list.Add(sb.ToString());
        }

        return list;
    }
}