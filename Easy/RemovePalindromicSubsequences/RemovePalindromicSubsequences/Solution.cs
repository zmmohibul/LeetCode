namespace RemovePalindromicSubsequences;

public class Solution 
{
    public int RemovePalindromeSub(string s) {
        var i = 0;
        var j = s.Length - 1;
        var isPalindrome = true;
        while (i < j)
        {
            if (s[i] != s[j])
            {
                isPalindrome = false;
                break;
            }
            i++;
            j--;
        }

        if (isPalindrome)
        {
            return 1;
        }

        return 2;
    }
}