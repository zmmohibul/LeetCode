namespace LargestLocalValuesInMatrix;

public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        var n = grid.Length;
        var result = new int[n - 2][];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new int[n - 2];
            for (int j = 0; j < result[i].Length; j++)
            {
                var gridRow = i + 1;
                var gridColumn = j + 1;

                var localValues = new List<int>();
                localValues.Add(grid[gridRow][gridColumn]); // mid
                
                localValues.Add(grid[gridRow - 1][gridColumn]); // top
                localValues.Add(grid[gridRow - 1][gridColumn - 1]); // top left
                localValues.Add(grid[gridRow - 1][gridColumn + 1]); // top right
                
                localValues.Add(grid[gridRow + 1][gridColumn]); // bottom
                localValues.Add(grid[gridRow + 1][gridColumn - 1]); // bottom left
                localValues.Add(grid[gridRow + 1][gridColumn + 1]); // bottom right
                
                localValues.Add(grid[gridRow][gridColumn - 1]); // left
                localValues.Add(grid[gridRow][gridColumn + 1]); // right

                var max = localValues.Max();
                result[i][j] = max;
            }
        }

        return result;
    }
}