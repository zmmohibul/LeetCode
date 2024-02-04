namespace CountUnreachablePairsOfNodesInAnUndirectedGraph;

public class Solution 
{
    Dictionary<int, List<int>> adj = new();
    HashSet<int> visited = new();
    public long CountPairs(int n, int[][] edges) 
    {
        foreach (var edge in edges)
        {
            int u = edge[0], v = edge[1];

            adj[u] = adj.GetValueOrDefault(u, new());
            adj[u].Add(v);

            adj[v] = adj.GetValueOrDefault(v, new());
            adj[v].Add(u);
        }

        long totalNodeCount = n;
        long result = 0;
        for (int i = 0; i < n; i++)
        {
            if (!visited.Contains(i))
            {
                long iNodeCount = BfsNodeCount(i);
                totalNodeCount -= iNodeCount;
                result += (iNodeCount * totalNodeCount);
            }
        }

        return result;
    }

    public int BfsNodeCount(int start)
    {
        int nodeCount = 0;
        var queue = new Queue<int>();
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            nodeCount++;

            var u = queue.Dequeue();
            visited.Add(u);

            if (adj.ContainsKey(u))
            {
                foreach (var v in adj[u])
                {
                    if (!visited.Contains(v))
                    {
                        visited.Add(v);
                        queue.Enqueue(v);
                    }
                }
            }
        }

        return nodeCount;
    }
}