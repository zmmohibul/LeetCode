namespace SumOfDigitsOfStringAfterConvert;

public class Solution
{
    public int GetLucky(string s, int k)
    {
        var sum = 0;
        foreach (var c in s)
        {
            var n = c - 'a' + 1;
            while (n > 0)
            {
                sum += (n % 10);
                n /= 10;
            }
        }
        
        for (int i = 1; i < k; i++)
        {
            var newSum = 0;
            while (sum > 0)
            {
                newSum += (sum % 10);
                sum /= 10;
            }

            sum = newSum;
        }
        
        return sum;
    }
}