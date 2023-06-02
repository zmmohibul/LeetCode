namespace RemoveTrailingZerosFromString;

public class Solution
{
    public string RemoveTrailingZeros(string num)
    {
        var i = num.Length - 1;
        while (i >= 0 && num[i] == '0')
        {
            i--;
        }

        if (i < num.Length)
        {
            num = num.Remove(i + 1);
        }

        return num;
    }
}