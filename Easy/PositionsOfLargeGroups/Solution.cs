namespace PositionsOfLargeGroups;

public class Solution {
    public IList<IList<int>> LargeGroupPositions(string s) {
        var start = 0;
        var end = 0;
        var result = new List<IList<int>>();
        while (end < s.Length)
        {
            while (end < s.Length && s[start] == s[end])
            {
                end++;
            }

            if (end - start >= 3)
            {
                result.Add(new List<int>{ start, end - 1 });
            }
            start = end;
        }

        return result;
    }
}