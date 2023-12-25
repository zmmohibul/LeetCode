namespace DecodeWays;

public class Solution {
    Dictionary<int, int> memo = new();
    public int NumDecodings(string s) {
        return Compute(0, s);
    }

    public int Compute(int index, string s)
    {
        if (memo.ContainsKey(index))
        {
            return memo[index];
        }

        if (index == s.Length)
        {
            return 1;
        }

        if (s[index] == '0')
        {
            return 0;
        }

        if (index == s.Length - 1)
        {
            return 1;
        }

        int ans = Compute(index + 1, s);
        if (Convert.ToInt32(s.Substring(index, 2)) <= 26)
        {
            ans += Compute(index + 2, s);
        }

        memo[index] = ans;

        return ans;


    }
}