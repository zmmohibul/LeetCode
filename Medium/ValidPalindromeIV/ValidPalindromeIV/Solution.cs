namespace ValidPalindromeIV;

public class Solution
{
    public bool MakePalindrome(string s) 
    {
        var misMatch = 0;
        var i = 0;
        var j = s.Length - 1;
        while(i < j)
        {
            if (s[i] != s[j])
            {
                misMatch++;
            }

            if (misMatch > 2)
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
        
    }
}