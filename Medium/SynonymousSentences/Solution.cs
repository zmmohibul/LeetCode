namespace SynonymousSentences;

public class Solution 
{
    Dictionary<string, HashSet<string>> synonymGroups = new();
    List<string> wordsInText = new();
    List<List<string>> result = new(); 
    public IList<string> GenerateSentences(IList<IList<string>> synonyms, string text) 
    {
        for (var i = 0; i < synonyms.Count; i++)
        {
            var pair = synonyms[i];
            var word1 = pair[0];
            var word2 = pair[1];

            var group = new HashSet<string>();
            if (synonymGroups.ContainsKey(word1))
            {
                group = synonymGroups[word1];   
            }
            else if (synonymGroups.ContainsKey(word2))
            {
                group = synonymGroups[word2];
            }
            else
            {
                group.Add(word1);
                group.Add(word2);

                synonymGroups[word1] = group;
                synonymGroups[word2] = group;
            }
            
            for (int j = i + 1; j < synonyms.Count; j++)
            {
                if (synonyms[j][0].Equals(word1) || synonyms[j][0].Equals(word2))
                {
                    group.Add(synonyms[j][0]);
                    group.Add(synonyms[j][1]);

                    synonymGroups[synonyms[j][0]] = group;
                    synonymGroups[synonyms[j][1]] = group;
                }
                else if (synonyms[j][1].Equals(word1) || synonyms[j][1].Equals(word2))
                {
                    group.Add(synonyms[j][0]);
                    group.Add(synonyms[j][1]);

                    synonymGroups[synonyms[j][0]] = group;
                    synonymGroups[synonyms[j][1]] = group;
                }
            }
        }

        foreach (var (word, wordSynonyms) in synonymGroups)
        {
            wordSynonyms.Remove(word);
            Console.Write($"{word}: ");
            foreach (var item in wordSynonyms)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();


        wordsInText = text.Split().ToList();
        result.Add(wordsInText);
        for (int i = 0; i < wordsInText.Count; i++)
        {
            var word = wordsInText[i];
            var newResult = new List<List<string>>(result);
            if (synonymGroups.ContainsKey(word))
            {
                foreach (var item in result)
                {
                    foreach (var synonym in synonymGroups[word])
                    {
                        var newItem = new List<string>(item) {[i] = synonym};
                        newResult.Add(newItem);
                    }
                }
            }

            result = newResult;
        }

        var resultStrings = new HashSet<string>();
        foreach (var item in result)
        {
            var str = string.Join(" ", item);
            resultStrings.Add(str);
        }
        return resultStrings.ToList();
    }
}