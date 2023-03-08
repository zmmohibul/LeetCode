namespace SingleRowKeyboard;

public class Solution
{
    public int CalculateTime(string keyboard, string word)
    {
        var charMap = new Dictionary<char, int>();
        for (int i = 0; i < keyboard.Length; i++)
        {
            charMap[keyboard[i]] = i;
        }

        foreach (var (ch, i) in charMap)
        {
            Console.WriteLine($"{ch}: {i}");
        }

        var time = 0;
        var currentInd = 0;
        for (int i = 0; i < word.Length; i++)
        {
            time += Math.Abs(currentInd - charMap[word[i]]);
            currentInd = charMap[word[i]];
        }

        return time;
    }
}