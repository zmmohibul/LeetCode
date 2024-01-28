namespace NumberOfDistinctIslands;

public class Solution 
{
    public int NumDistinctIslands(int[][] grid) 
    {
        var componentsInGrid = new List<HashSet<Tuple<int, int>>>();
        for (var row = 0; row < grid.Length; row++)
        {
            for (var col = 0; col < grid[0].Length; col++)
            {
                if (grid[row][col] == 1)
                {
                    var nodesInComponent = new HashSet<Tuple<int, int>>();
                    Dfs(grid, nodesInComponent, row, col);
                    componentsInGrid.Add(nodesInComponent);
                }
            }
        }

        var equalGraphIndices = new HashSet<int>();
        var equalGraphGroups = new List<HashSet<int>>();
        for (int i = 0; i < componentsInGrid.Count; i++) 
        {
            if (equalGraphIndices.Contains(i)) 
            {
                continue;
            }

            var equalGraphGroup = new HashSet<int>() {i};
            var comp1 = componentsInGrid[i];
            for (int j = i + 1; j < componentsInGrid.Count; j++) 
            {
                if (j != i) 
                {
                    var comp2 = componentsInGrid[j];
                    if (comp2.Count == comp1.Count) {
                        var equalGraph = true;

                        var node1 = comp1.ElementAt(0);
                        var node2 = comp2.ElementAt(0);

                        var rowDiff = Math.Abs(node2.Item1 - node1.Item1);
                        var colDiff = Math.Abs(node2.Item2 - node1.Item2);

                        for (int k = 1; k < comp1.Count; k++) 
                        {
                            node1 = comp1.ElementAt(k);
                            node2 = comp2.ElementAt(k);
                            
                            if (Math.Abs(node2.Item1 - node1.Item1) != rowDiff || 
                                Math.Abs(node2.Item2 - node1.Item2) != colDiff) 
                            {
                                equalGraph = false;
                                break;
                            }
                        }

                        if (equalGraph) 
                        {
                            equalGraphIndices.Add(i);
                            equalGraphIndices.Add(j);
                            equalGraphGroup.Add(j);
                        }
                    }
                }
            }

            if (equalGraphGroup.Count > 1) 
            {
                equalGraphGroups.Add(equalGraphGroup);
            }
        }

        var distinctCount = 0;
        for (int i = 0; i < componentsInGrid.Count; i++) 
        {
            if (!equalGraphIndices.Contains(i)) 
            {
                distinctCount++;
            }
        }

        distinctCount += equalGraphGroups.Count;

        return distinctCount;
    }

    public void Dfs(int[][] grid, HashSet<Tuple<int, int>> vertices, int row, int col)
    {
        if (!InBound(grid, row, col))
        {
            return;
        }

        vertices.Add(new Tuple<int, int>(row, col));
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

