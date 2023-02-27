using System.Text;

namespace LetterCombinationsOfPhoneNumber;

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        var numMap = new Dictionary<char, IList<string>>();
        numMap['2'] = new List<string>() { "a", "b", "c" };
        numMap['3'] = new List<string>() { "d", "e", "f" };
        numMap['4'] = new List<string>() { "g", "h", "i" };
        numMap['5'] = new List<string>() { "j", "k", "l" };
        numMap['6'] = new List<string>() { "m", "n", "o" };
        numMap['7'] = new List<string>() { "p", "q", "r", "s" };
        numMap['8'] = new List<string>() { "t", "u", "v" };
        numMap['9'] = new List<string>() { "w", "x", "y", "z" };
        return LetterCombinations(digits, numMap);
    }

    public IList<string> LetterCombinations(string digits, IDictionary<char, IList<string>> numMap)
    {
        if (digits.Length == 0)
        {
            return new List<string>();
        }
        else if (digits.Length == 1)
        {
            return numMap[digits[0]];
        }
        else
        {
            var result = new List<string>();
            var currCharMap = numMap[digits[0]];
            var remCombinations = LetterCombinations(digits.Remove(0, 1), numMap);
            foreach (var ch in currCharMap)
            {
                foreach (var rem in remCombinations)
                {
                    result.Add(ch+rem);
                }
            }

            return result;

        }
    }
}