namespace PrimePalindrome;

public class Solution 
{
    public int PrimePalindrome(int n) 
    {
        if (n < 2)
        {
            return 2;
        }

        var i = n;
        while (true)
        {
            if (IsPalindrome(i) && IsPrime(i))
            {
                return i;
            }

            i++;
        }
    }

    public bool IsPrime(int n)
    {
        var half = Math.Sqrt(n);
        half++;
        for (int i = 2; i < half; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public bool IsPalindrome(int n)
    {
        var orgN = n;
        var rev = 0;
        while (n > 0)
        {
            rev *= 10;
            rev += n % 10;
            n /= 10;
        }

        return orgN == rev;
    }
}
