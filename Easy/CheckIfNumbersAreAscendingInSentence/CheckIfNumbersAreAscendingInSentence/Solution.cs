namespace CheckIfNumbersAreAscendingInSentence;

public class Solution
{
    public bool AreNumbersAscending(string s)
    {
        var last = -1;
        var i = 0;
        while (i < s.Length)
        {
            var num = 0;
            if (char.IsDigit(s[i]))
            {
                while (i < s.Length && char.IsDigit(s[i]))
                {
                    num *= 10;
                    num += (s[i] - '0');
                    i++;
                }
                
                if (num <= last)
                {
                    return false;
                }
            
                last = num;
            }

            i++;
        }

        return true;
    }
}