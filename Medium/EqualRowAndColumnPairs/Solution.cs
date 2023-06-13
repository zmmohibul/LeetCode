namespace EqualRowAndColumnPairs;

public class Solution
{
    public int EqualPairs(int[][] grid)
    {
        var count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int col = 0; col < grid[i].Length; col++)
            {
                var match = true;
                for (int row = 0; row < grid.Length; row++)
                {
                    if (grid[i][row] != grid[row][col])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    count++;
                }
            }
        }

        return count;
    }
}