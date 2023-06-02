namespace LargestOddNumberInString;

public class Solution
{
    public string LargestOddNumber(string num)
    {
        for (int i = num.Length - 1; i > -1; i--)
        {
            var n = num[i] - 48;
            if (n % 2 != 0)
            {
                return num.Substring(0, i + 1);
            }
        }

        return string.Empty;
    }
}