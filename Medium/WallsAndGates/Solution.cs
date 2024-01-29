namespace WallsAndGates;

public class Solution {
    HashSet<Tuple<int, int>> roomTuples = new();
    HashSet<Tuple<int, int>> gates = new();
    public void WallsAndGates(int[][] rooms) {
        var adj = GetAdj(rooms);
        if (gates.Count == 0 || roomTuples.Count == 0)
        {
            return;
        }

        var queue = new HashSet<Tuple<int, int>>();
        foreach (var gate in gates)
        {
            queue.Add(gate);
        }

        var visited = new HashSet<Tuple<int, int>>();
        var level = 0;
        
        while (queue.Count > 0)
        {
            var queueCount = queue.Count;
            var newQueue = new HashSet<Tuple<int, int>>();
            for (int i = 0; i < queueCount; i++)
            {
                var u = queue.First();
                queue.Remove(u);
                visited.Add(u);

                Console.Write($"({u.Item1}, {u.Item2}), ");


                if (roomTuples.Contains(u))
                {
                    var row = u.Item1;
                    var col = u.Item2;
                    if (rooms[row][col] > level) 
                    {
                        rooms[row][col] = level;
                    }

                    roomTuples.Remove(u);
                }

                foreach (var v in adj[u])
                {
                    if (!visited.Contains(v) && roomTuples.Contains(v))
                    {
                        newQueue.Add(v);
                    }
                }
            }

            Console.WriteLine();
            queue = newQueue;
            level++;
        }

        return;
    }

    public Dictionary<Tuple<int, int>, List<Tuple<int, int>>> GetAdj(int[][] grid)
    {
        var adj = new Dictionary<Tuple<int, int>, List<Tuple<int, int>>>();
        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                var val = grid[row][col];
                if (val != -1)
                {
                    var t = new Tuple<int, int>(row, col);

                    if (val == 0) 
                    {
                        gates.Add(t);
                    }
                    else 
                    {
                        roomTuples.Add(t);
                    }

                    if (!adj.ContainsKey(t))
                    {
                        adj[t] = new();
                    }

                    if (row + 1 != grid.Length && grid[row + 1][col] != -1)
                    {
                        adj[t].Add(new Tuple<int, int>(row + 1, col));
                    }

                    if (row - 1 != -1 && grid[row - 1][col] != -1)
                    {
                        adj[t].Add(new Tuple<int, int>(row - 1, col));
                    }

                    if (col + 1 != grid[0].Length && grid[row][col + 1] != -1)
                    {
                        adj[t].Add(new Tuple<int, int>(row, col + 1));
                    }

                    if (col - 1 != -1 && grid[row][col - 1] != -1)
                    {
                        adj[t].Add(new Tuple<int, int>(row, col - 1));
                    }
                }
            }
        }

        return adj;
    }
}