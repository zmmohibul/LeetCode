namespace MinimumNumberOfVerticesToReachAllNodes;

public class Solution 
{
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) 
    {
        var inDegreeFreq = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            inDegreeFreq[i] = 0;
        }
        
        foreach (var edge in edges)
        {
            inDegreeFreq[edge[1]]++;
        }

        var result = new List<int>();
        foreach (var (v, inDeg) in inDegreeFreq)
        {
            if (inDeg == 0)
            {
                result.Add(v);
            }
        }

        return result;
    }
}