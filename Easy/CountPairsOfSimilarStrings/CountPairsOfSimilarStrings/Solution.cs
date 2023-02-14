public class Solution
{
    public int SimilarPairs(string[] words)
    {
        var count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            var hs = new HashSet<char>();
            var word = words[i];
            for (int j = 0; j < word.Length; j++)
            {
                hs.Add(word[j]);
            }

            for (int j = i + 1; j < words.Length; j++)
            {
                var innerWord = words[j];
                var isSame = true;
                var innerHs = new HashSet<char>();
                for (int k = 0; k < innerWord.Length; k++)
                {
                    if (!hs.Contains(innerWord[k]))
                    {
                        isSame = false;
                        break;
                    }
                    innerHs.Add(innerWord[k]);
                }
                

                if (isSame && innerHs.Count == hs.Count)
                {
                    count += 1;
                }
            }
        }

        return count;
    }
}