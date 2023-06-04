namespace ConsoleApp1;

public class Solution
{
    public int MinMeetingRooms(int[][] intervals)
    {
        var intervalsSortedByStart = intervals.OrderBy(x => x[0]).ToArray();
        var hs = new HashSet<int>();
        var count = 0;
        for (int i = 0; i < intervalsSortedByStart.Length; i++)
        {
            if (!hs.Contains(i))
            {
                var lastEnd = intervalsSortedByStart[i][1];
                hs.Add(i);
                for (int j = 0; j < intervalsSortedByStart.Length; j++)
                {
                    if (!hs.Contains(j) && intervalsSortedByStart[j][0] >= lastEnd)
                    {
                        lastEnd = intervalsSortedByStart[j][1];
                        hs.Add(j);
                    }
                }

                count++;
            }
        }

        return count;
    }
}