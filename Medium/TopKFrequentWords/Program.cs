var words = new string[] { "i", "love", "leetcode", "i", "love", "coding" };
var topK = TopKFrequent(words, 2);
foreach (var word in topK)
{
    Console.Write($"{word}, ");
}


IList<string> TopKFrequent(string[] words, int k)
{
    var wordFrequency = new Dictionary<string, int>();
    foreach (var word in words)
    {
        wordFrequency[word] = wordFrequency.GetValueOrDefault(word) + 1;
    }

    var sortedFrequencyMap = new SortedDictionary<int, List<string>>();
    foreach (var (word, count) in wordFrequency)
    {
        if (!sortedFrequencyMap.ContainsKey(count))
        {
            sortedFrequencyMap[count] = new();
        }
        sortedFrequencyMap[count].Add(word);
    }

    var result = new List<string>();
    var iend = sortedFrequencyMap.Count - 1;
    for (var i = 0; i < sortedFrequencyMap.Count && result.Count < k; i++)
    {
        var dictElement = sortedFrequencyMap.ElementAt(iend);
        dictElement.Value.Sort();
        foreach (var word in dictElement.Value)
        {
            result.Add(word);
            if (result.Count == k) break;
        }

        iend--;
    }

    return result;
}