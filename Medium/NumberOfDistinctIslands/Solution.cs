namespace NumberOfDistinctIslands;

public class Solution {
    bool equalGraph = true;
    public int NumDistinctIslands(int[][] grid) {
        var adj = GetAdj(grid);
        if (adj.Count == 0) {
            return 0;
        }

        var componentsInGrid = new List<HashSet<Tuple<int, int>>>();
        var currComponent = new HashSet<Tuple<int, int>>();

        var visited = new HashSet<Tuple<int, int>>();
        var queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(adj.ElementAt(0).Key);

        while (queue.Count > 0) {
            var u = queue.Dequeue();
            visited.Add(u);

            if (adj.ContainsKey(u)) {
                currComponent.Add(u);
                foreach (var v in adj[u]) {
                    if (!visited.Contains(v)) {
                        queue.Enqueue(v);
                    }
                }

                adj.Remove(u);
            }

            if (queue.Count == 0 && adj.Count != 0) {
                componentsInGrid.Add(currComponent);
                currComponent = new();

                queue.Enqueue(adj.ElementAt(0).Key);
            } 
        }

        componentsInGrid.Add(currComponent);

        var equalGraphIndices = new HashSet<int>();
        var equalGraphGroups = new List<HashSet<int>>();
        for (int i = 0; i < componentsInGrid.Count; i++) {
            if (equalGraphIndices.Contains(i)) {
                continue;
            }

            var equalGraphGroup = new HashSet<int>() {i};
            var comp1 = componentsInGrid[i];
            for (int j = i + 1; j < componentsInGrid.Count; j++) {
                if (j != i) {
                    var comp2 = componentsInGrid[j];
                    if (comp2.Count == comp1.Count) {
                        var equalGraph = true;

                        var node1 = comp1.ElementAt(0);
                        var node2 = comp2.ElementAt(0);

                        var rowDiff = Math.Abs(node2.Item1 - node1.Item1);
                        var colDiff = Math.Abs(node2.Item2 - node1.Item2);

                        for (int k = 1; k < comp1.Count; k++) {
                            node1 = comp1.ElementAt(k);
                            node2 = comp2.ElementAt(k);
                            
                            if (Math.Abs(node2.Item1 - node1.Item1) != rowDiff
                                || Math.Abs(node2.Item2 - node1.Item2) != colDiff
                               ) {
                                equalGraph = false;
                                break;
                            }
                        }

                        if (equalGraph) {
                            equalGraphIndices.Add(i);
                            equalGraphIndices.Add(j);
                            equalGraphGroup.Add(j);
                        }
                    }
                }
            }

            if (equalGraphGroup.Count > 1) {
                equalGraphGroups.Add(equalGraphGroup);
            }
        }

        var distinctCount = 0;
        for (int i = 0; i < componentsInGrid.Count; i++) {
            if (!equalGraphIndices.Contains(i)) {
                distinctCount++;
            }
        }

        distinctCount += equalGraphGroups.Count;

        return distinctCount;
    }

    public Dictionary<Tuple<int, int>, List<Tuple<int, int>>> GetAdj(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        var adj = new Dictionary<Tuple<int, int>, List<Tuple<int, int>>>();
        for (int row = 0; row < m; row++) {
            for (int col = 0; col < n; col++) {
                if (grid[row][col] == 1) {
                    var u = new Tuple<int, int>(row, col);
                    if (!adj.ContainsKey(u)) {
                        adj[u] = new();
                    }

                    if (row + 1 < m && grid[row + 1][col] == 1) {
                        adj[u].Add(new Tuple<int, int>(row + 1, col));
                    }

                    if (row - 1 > -1 && grid[row - 1][col] == 1) {
                        adj[u].Add(new Tuple<int, int>(row - 1, col));
                    }

                    if (col + 1 < n && grid[row][col + 1] == 1) {
                        adj[u].Add(new Tuple<int, int>(row, col + 1));
                    }

                    if (col - 1 > -1 && grid[row][col - 1] == 1) {
                        adj[u].Add(new Tuple<int, int>(row, col - 1));
                    }
                }
            }
        }

        return adj;
    }
}

