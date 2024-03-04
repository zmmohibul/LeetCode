namespace BagOfTokens;

public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {
        Array.Sort(tokens);
        int score = 0, left = 0, right = tokens.Length - 1;
        for (var i = 0; i < tokens.Length && left < right; i++)
        {
            if (tokens[left] <= power)
            {
                power -= tokens[left];
                score++;
                left++;
            }
            else if (score > 0)
            {
                power += tokens[right];
                right--;
                score--;
            }
            else 
            {
                return score;
            }
        }

        if (left == right && tokens[left] <= power)
        {
            score++;
        }
        
        return score;
    }
}