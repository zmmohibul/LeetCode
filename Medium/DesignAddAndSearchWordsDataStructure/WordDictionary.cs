namespace DesignAddAndSearchWordsDataStructure;

public class WordDictionary
{
    private Node Root { get; set; } = new();

    public void AddWord(string word)
    {
        var curr = Root;
        foreach (var c in word)
        {
            if (!curr.Children.ContainsKey(c))
            {
                curr.Children[c] = new();
                // curr.Children[c].Letter = c;
            }
            curr = curr.Children[c];
        }

        curr.IsTerminal = true;
    }
    
    public bool Search(string word)
    {
        return Search(word, 0, Root);
    }

    private bool Search(string word, int start, Node curr)
    {
        for (var i = start; i < word.Length; i++)
        {
            var c = word[i];
            if (c == '.')
            {
                foreach (var (letter, n) in curr.Children)
                {
                    var res = Search(word, i + 1, n);
                    if (res) return res;
                }

                return false;
            }
            
            if (!curr.Children.ContainsKey(c)) return false;
            curr = curr.Children[c];
        }

        return curr.IsTerminal;
    }
    
    public class Node
    {
        // public char Letter { get; set; }
        public bool IsTerminal { get; set; }
        public Dictionary<char, Node> Children { get; set; } = new();
    }
}