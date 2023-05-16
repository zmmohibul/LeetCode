namespace LongestPalindromicSubstring;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        var charIndices = new Dictionary<char, List<int>>();
        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (!charIndices.ContainsKey(c))
            {
                charIndices[c] = new List<int>();
            }

            charIndices[c].Add(i);
        }

        var palindromes = new List<string>();
        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];

            for (int a = charIndices[c].Count - 1; a > 0; a--)
            {
                var j = charIndices[c][a];
                if (j > i && IsPalindrome(i, j, s))
                {
                    var ps = s.Substring(i, j - i + 1);
                    palindromes.Add(ps);
                    break;
                }
            }
        }

        if (palindromes.Count == 0)
        {
            return s[0].ToString();
        }
        
        var maxLength = 0;
        var maxPalindrome = string.Empty;

        foreach (var palindrome in palindromes)
        {
            if (palindrome.Length > maxLength)
            {
                maxLength = palindrome.Length;
                maxPalindrome = palindrome;
            }
        }

        return maxPalindrome;

    }


    public bool IsPalindrome(int left, int right, string s)
    {
        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }

        return true;
    }
    
    
}