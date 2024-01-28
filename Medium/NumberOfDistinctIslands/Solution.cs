using System.Text;

namespace NumberOfDistinctIslands;

public class Solution 
{
    int rowOrigin = 0;
    int colOrigin = 0;
    public int NumDistinctIslands(int[][] grid) 
    {
        var stringComps = new HashSet<string>();
        for (var row = 0; row < grid.Length; row++)
        {
            for (var col = 0; col < grid[0].Length; col++)
            {
                if (grid[row][col] == 1)
                {
                    rowOrigin = row;
                    colOrigin = col;

                    var nodesInComponent = new HashSet<Tuple<int, int>>();
                    Dfs(grid, nodesInComponent, row, col);
                    
                    var sb = new StringBuilder();
                    foreach (var item in nodesInComponent) 
                    {
                        sb.Append($"({item.Item1}-{item.Item2})-");
                    }
                    
                    stringComps.Add(sb.ToString());
                }
            }
        }

        return stringComps.Count;
    }

    public void Dfs(int[][] grid, HashSet<Tuple<int, int>> vertices, int row, int col)
    {
        if (!InBound(grid, row, col))
        {
            return;
        }

        vertices.Add(new Tuple<int, int>(row - rowOrigin, col - colOrigin));
        grid[row][col] = 2;
        
        Dfs(grid, vertices, row + 1, col);
        Dfs(grid, vertices, row - 1, col);
        Dfs(grid, vertices, row, col + 1);
        Dfs(grid, vertices, row, col - 1);

    }
    
    public bool InBound(int[][] grid, int row1, int col1) 
    {
        if (row1 == -1
            || row1 == grid.Length
            || col1 == grid[0].Length
            || col1 == -1
            || grid[row1][col1] == 0
            || grid[row1][col1] == 2
           ) {
            return false;
        }

        return true;
    }
}

