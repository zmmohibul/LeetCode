namespace CheckIfTheSentenceIsPangram;

public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        var hs = new HashSet<char>();
        for (int i = 0; i < sentence.Length; i++)
        {
            hs.Add(sentence[i]);
            if (hs.Count == 26)
            {
                return true;
            }
        }

        return false;
    }
}