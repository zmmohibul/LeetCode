namespace ReverseWordsInStringII;

public class Solution {
    public void ReverseWords(char[] s) {
        var i = 0;
        var j = s.Length - 1;
        while (i < j)
        {
            (s[j], s[i]) = (s[i], s[j]);

            i++;
            j--;
        }

        i = 0;
        j = 0;
        while (j < s.Length)
        {
            while (j < s.Length && s[j] != ' ')
            {
                j++;
            }
            var tj = j;
            j--;

            while (i < j)
            {
                (s[j], s[i]) = (s[i], s[j]);

                i++;
                j--;
            }
            
            i = tj + 1;
            j = i;
        }        
    }
}