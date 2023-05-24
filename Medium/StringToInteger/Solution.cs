namespace StringToInteger;

public class Solution 
{
    public int MyAtoi(string s) 
    {
        var i = 0;
        while (i < s.Length && s[i] == ' ')
        {
            i++;
        }
        
        var negative = false;
        if (i < s.Length)
        {
            if (s[i] == '-')
            {
                negative = true;
                i++;
            }
            else if (s[i] == '+')
            {
                i++;
            }
        }

        while (i < s.Length && s[i] == '0')
        {
            i++;
        }

        var hs = new HashSet<char>() {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        long num = 0;
        var size = 0;
        var maxReached = false;
        while (i < s.Length && hs.Contains(s[i]) && size < 11)
        {
            int n = s[i] - '0';
            num *= 10;
            num += n;

            i++;
            size++;
        }

        if (negative)
        {
            num = num * -1;
        }

        if (num > int.MaxValue)
        {
            return int.MaxValue;
        }
        else if (num < int.MinValue)
        {
            return int.MinValue;
        }
        else 
        {
            return (int) num;
        }
        
    }
}