namespace FindCommonCharacters;

public class Solution {
    public IList<string> CommonChars(string[] words) {
        var result = new List<string>();
        var word = words[0];
        for (int i = 0; i < word.Length; i++)
        {
            var c = word[i];
            var cn = true;
            for (int j = 1; j < words.Length; j++)
            {
                var wd = words[j];
                if (!wd.Contains(c))
                {
                    
                }
            }
        }
        
        return result;
    }
}