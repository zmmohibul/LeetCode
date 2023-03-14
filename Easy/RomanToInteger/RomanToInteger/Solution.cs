namespace RomanToInteger;

public class Solution {
    public int RomanToInt(string s) {
        var sum = 0;
        int i;
        for (i = s.Length - 1; i > 0; i--)
        {
            if (s[i] == 'V')
            {
                if (s[i - 1] == 'I')
                {
                    sum += 4;
                    i--;
                }
                else
                {
                    sum += 5;
                }
            }
            else if (s[i] == 'X')
            {
                if (s[i - 1] == 'I')
                {
                    sum += 9;
                    i--;
                }
                else
                {
                    sum += 10;
                }
            }
            else if (s[i] == 'L')
            {
                if (s[i - 1] == 'X')
                {
                    sum += 40;
                    i--;
                }
                else
                {
                    sum += 50;
                }
            }
            else if (s[i] == 'C')
            {
                if (s[i - 1] == 'X')
                {
                    sum += 90;
                    i--;
                }
                else
                {
                    sum += 100;
                }
            }
            else if (s[i] == 'D')
            {
                if (s[i - 1] == 'C')
                {
                    sum += 400;
                    i--;
                }
                else
                {
                    sum += 500;
                }
            }
            else if (s[i] == 'M')
            {
                if (s[i - 1] == 'C')
                {
                    sum += 900;
                    i--;
                }
                else
                {
                    sum += 1000;
                }
            }
            else if (s[i] == 'I')
            {
                sum += 1;
            }
        }

        if (i == 0)
        {
            if (s[i] == 'V')
            {
                sum += 5;
            }
            else if (s[i] == 'X')
            {
                sum += 10;
            }
            else if (s[i] == 'L')
            {
                sum += 50;

            }
            else if (s[i] == 'C')
            {
                sum += 100;

            }
            else if (s[i] == 'D')
            {
                sum += 500;

            }
            else if (s[i] == 'M')
            {
                sum += 1000;
            }
            else if (s[i] == 'I')
            {
                sum += 1;
            }
        }
        
        return sum;
    }
}