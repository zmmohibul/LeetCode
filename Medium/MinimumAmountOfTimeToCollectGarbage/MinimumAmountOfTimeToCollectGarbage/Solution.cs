namespace MinimumAmountOfTimeToCollectGarbage;

public class Solution
{
    public int GarbageCollection(string[] garbage, int[] travel)
    {
        var lastSeenIndex = new Dictionary<char, int>();
        for (int i = 0; i < garbage.Length; i++)
        {
            foreach (var ch in garbage[i])
            {
                lastSeenIndex[ch] = i;
            }
        }

        var totalTime = 0;
        for (int i = 0; i < garbage.Length; i++)
        {
            foreach (var type in garbage[i])
            {
                totalTime++;
            }

            foreach (var garbageType in lastSeenIndex.Keys)
            {
                if (i < lastSeenIndex[garbageType])
                {
                    totalTime += travel[i];
                }
            }
        }

        return totalTime;
    }
}