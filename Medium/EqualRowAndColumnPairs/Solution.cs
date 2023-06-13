using System.Text;

namespace EqualRowAndColumnPairs;

public class Solution
{
    public int EqualPairs(int[][] grid)
    {
        var rowFreq = new Dictionary<string, int>();
        for (int r = 0; r < grid.Length; r++)
        {
            var sb = new StringBuilder();
            for (int c = 0; c < grid.Length; c++)
            {
                sb.Append(grid[r][c]);
                sb.Append('-');
            }

            var s = sb.ToString();
            rowFreq[s] = rowFreq.GetValueOrDefault(s, 0) + 1;
        }
        
        var count = 0;
        for (int r = 0; r < grid.Length; r++)
        {
            var sb = new StringBuilder();
            for (int c = 0; c < grid.Length; c++)
            {
                sb.Append(grid[c][r]);
                sb.Append('-');
            }

            var s = sb.ToString();
            if (rowFreq.ContainsKey(s))
            {
                count += rowFreq[s];
            }
        }

        return count;
    }
}