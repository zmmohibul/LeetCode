namespace DeleteGreatestValueInEachRow;

public class Solution 
{
    public int DeleteGreatestValue(int[][] grid) {
        var sum = 0;
        for (int k = 0; k < grid[0].Length; k++)
        {
            var max = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                var rowMax = 0;
                var rowMaxInd = -1;
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] > rowMax)
                    {
                        rowMax = grid[i][j];
                        rowMaxInd = j;
                    }
                }
                grid[i][rowMaxInd] = 0;
                if (rowMax > max)
                {
                    max = rowMax;
                }
            }
            sum += max;
        }
        return sum;
        
    }
}