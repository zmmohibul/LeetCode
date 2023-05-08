namespace MaximumNumberOfWordsYouCanType;

public class Solution
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        var hsBrokenLetters = new HashSet<char>();
        for (var i = 0; i < brokenLetters.Length; i++) hsBrokenLetters.Add(brokenLetters[i]);

        var count = 0;
        var j = 0;
        while (j < text.Length)
        {
            var k = j;
            var canType = true;
            while (k < text.Length && text[k] != ' ')
            {
                if (hsBrokenLetters.Contains(text[k])) canType = false;

                k++;
            }

            if (canType) count++;

            j = k;
            j++;
        }

        return count;
    }
}