namespace CourseScheduleII;

public class DirectedGraph 
{
    private Dictionary<int, List<int>> adj = new();
    private HashSet<int> processing = new();
    private HashSet<int> processed = new();

    private HashSet<int> visited = new();
    private List<int> topologicalSortedList = new();

    private int numberOfVertices = 0;

    public DirectedGraph(int numCourses, int[][] prerequisites)
    {
        numberOfVertices = numCourses;
        for (int i = 0; i < numberOfVertices; i++)
        {
            adj[i] = new();
        }
        BuildAdjacencyList(prerequisites);
    }

    private void BuildAdjacencyList(int[][] edges)
    {
        foreach (var edge in edges) 
        {
            adj[edge[1]].Add(edge[0]);
        }
    }

    public int[] GetTopologicalSortedOrder()
    {
        if (GraphHasCycle())
        {
            return new int[numberOfVertices];
        }
        
        for (int i = 0; i < numberOfVertices; i++)
        {
            if (!visited.Contains(i))
            {
                visited.Add(i);
                TopologicalSort(i);
                topologicalSortedList.Add(i);
            }
        }

        var result = new int[numberOfVertices];
        var ri = 0;
        for (int i = topologicalSortedList.Count - 1; i > -1; i--)
        {
            result[ri] = topologicalSortedList[i];
            ri++;
        }

        return result;
    }

    private void TopologicalSort(int u)
    {
        foreach (var v in adj[u])
        {
            if (!visited.Contains(v))
            {
                visited.Add(v);
                TopologicalSort(v);
                topologicalSortedList.Add(v);
            }
        }
    }

    private bool GraphHasCycle()
    {
        for (int i = 0; i < numberOfVertices; i++)
        {
            if (!processed.Contains(i) && GraphHasCycle(i))
            {
                return true;
            }
        }

        return false;
    }

    private bool GraphHasCycle(int u)
    {
        if (processing.Contains(u)) {
            return true;
        }

        processing.Add(u);
        foreach (var v in adj[u]) {
            if (!processed.Contains(v) && GraphHasCycle(v)) {
                return true;
            }
        }

        processing.Remove(u);
        processed.Add(u);
        return false;
    }
}