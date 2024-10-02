public class MagicDictionary
{
    private HashSet<int> WordLengths { get; set; } = new();
    private HashSet<string> WordSet { get; set; } = new();
    public Node Root { get; set; } = new();
    
    public void BuildDict(string[] dictionary) {
        foreach (var word in dictionary)
        {
            WordSet.Add(word);
            WordLengths.Add(word.Length);
            var curr = Root;
            foreach (var c in word)
            {
                if (!curr.Children.ContainsKey(c)) curr.Children[c] = new();
                curr = curr.Children[c];
            }

            curr.IsTerminal = true;
        }
    }
    
    public bool Search(string searchWord)
    {
        if (!WordLengths.Contains(searchWord.Length)) return false;
        var found = false;
        foreach (var word in WordSet)
        {
            if (word.Length != searchWord.Length) continue;
            var mismatchCount = 0;
            for (var i = 0; i < word.Length; i++)
            {
                if (word[i] != searchWord[i])
                {
                    mismatchCount++;
                    if (mismatchCount == 2) break;
                }
            }

            if (mismatchCount == 1)
            {
                found = true;
                break;
            }
        }

        return found;
        if (!WordLengths.Contains(searchWord.Length)) return false;
        var cobj = new CountObj();
        return (SearchAndCountMismatch(searchWord, 0, Root, cobj) && cobj.Count == 1);
    }

    private bool SearchAndCountMismatch(string searchWord, int start, Node curr, CountObj countObj)
    {
        for (var i = start; i < searchWord.Length; i++)
        {
            if (!curr.Children.ContainsKey(searchWord[i]))
            {
                countObj.Count++;
                foreach (var (c, node) in curr.Children)
                {
                    return SearchAndCountMismatch(searchWord, i + 1, node, countObj) == true;
                }

                return false;
            }

            curr = curr.Children[searchWord[i]];
        }

        return curr.IsTerminal;
    }

    public class Node
    {
        public bool IsTerminal { get; set; }
        public Dictionary<char, Node> Children { get; set; } = new();
    }

    public class CountObj
    {
        public int Count { get; set; } = 0;
    }
}