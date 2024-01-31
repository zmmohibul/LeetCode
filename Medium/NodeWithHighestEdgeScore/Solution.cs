namespace NodeWithHighestEdgeScore;

public class Solution {
    public int EdgeScore(int[] edges) {
        var map = new Dictionary<int, long>();
        for (int i = 0; i < edges.Length; i++)
        {
            map[edges[i]] = map.GetValueOrDefault(edges[i]) + i;
        }

        var maxScore = map.Values.Max();
        for (int i = 0; i < edges.Length; i++)
        {
            if (map.GetValueOrDefault(i) == maxScore)
            {
                return i;
            }
        }

        return 0;
    }
}