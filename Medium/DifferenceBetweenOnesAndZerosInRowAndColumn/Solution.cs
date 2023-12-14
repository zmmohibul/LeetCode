namespace DifferenceBetweenOnesAndZerosInRowAndColumn;

public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        var rowOnesCount = new Dictionary<int, int>();
        var rowZerosCount = new Dictionary<int, int>();

        var columnOnesCount = new Dictionary<int, int>();
        var columnZerosCount = new Dictionary<int, int>();

        for (int i = 0; i < grid.Length; i++)
        {
            var zeroCount = 0;
            var oneCount = 0;
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    zeroCount++;
                }

                if (grid[i][j] == 1)
                {
                    oneCount++;
                }
            }

            rowOnesCount[i] = oneCount;
            rowZerosCount[i] = zeroCount;
        }

        for (int i = 0; i < grid[0].Length; i++)
        {
            var zeroCount = 0;
            var oneCount = 0;
            for (int j = 0; j < grid.Length; j++)
            {
                if (grid[j][i] == 0)
                {
                    zeroCount++;
                }

                if (grid[j][i] == 1)
                {
                    oneCount++;
                }
            }

            columnOnesCount[i] = oneCount;
            columnZerosCount[i] = zeroCount;
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                var diff = rowOnesCount[i] + columnOnesCount[j] - rowZerosCount[i] - columnZerosCount[j];
                grid[i][j] = diff;
            }
        }

        return grid;
    }
}