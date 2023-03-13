namespace RingsAndRods;

public class Solution
{
    public int CountPoints(string rings)
    {
        var rodToRingMap = new Dictionary<char, HashSet<char>>();
        for (int i = 0; i < rings.Length - 1; i += 2)
        {
            if (!rodToRingMap.ContainsKey(rings[i + 1]))
            {
                rodToRingMap[rings[i + 1]] = new HashSet<char>();
            }

            rodToRingMap[rings[i + 1]].Add(rings[i]);
        }

        var count = 0;
        foreach (var (rod, colors) in rodToRingMap)
        {
            if (colors.Count == 3)
            {
                count++;
            }
        }

        return count;
    }
}