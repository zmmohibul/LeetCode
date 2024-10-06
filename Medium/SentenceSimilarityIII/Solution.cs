namespace SentenceSimilarityIII;

public class Solution {
    public bool AreSentencesSimilar(string sentence1, string sentence2) {
        var wordsSentence1 = sentence1.Split(' ');
        var wordsSentence2 = sentence2.Split(' ');

        if (wordsSentence1.Length > wordsSentence2.Length)
        {
            (wordsSentence1, wordsSentence2) = (wordsSentence2, wordsSentence1);
        }

        if (wordsSentence1[0] != wordsSentence2[0] && wordsSentence1[^1] != wordsSentence2[^1]) return false;

        var match = 0;
        var i = 0;
        while (i < wordsSentence1.Length)
        {
            if (wordsSentence1[i] != wordsSentence2[i]) break;
            match++;
            i++;
        }
        if (i == wordsSentence1.Length) return true;
        
        var newi = wordsSentence1.Length - 1;
        var j = wordsSentence2.Length - 1;
        while (newi >= i && j > -1)
        {
            if (wordsSentence1[newi] != wordsSentence2[j]) return false;;
            newi--;
            j--;
        }

        return i == newi + 1;
    }

}