using System.Text;

namespace StrictlyPalindromicNumber;

public class Solution 
{
    public bool IsStrictlyPalindromic(int n) 
    {
        for (int i = 2; i < n - 1; i++)
        {
            var sb = new StringBuilder();
            
            var num = n;
            while (num > 0)
            {
                sb.Append(num % i);
                num /= i;
            }

            var left = 0;
            var right = sb.Length - 1;
            while (left < right)
            {
                if (sb[left] != sb[right])
                {
                    return false;
                }

                left++;
                right--;
            }
        }

        return true;
    }
}