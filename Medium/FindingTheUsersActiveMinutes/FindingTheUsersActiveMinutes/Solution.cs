namespace FindingTheUsersActiveMinutes;

public class Solution
{
    public int[] FindingUsersActiveMinutes(int[][] logs, int k)
    {
        var userActiveMinutes = new Dictionary<int, HashSet<int>>();
        foreach (var log in logs)
        {
            var userId = log[0];
            var taskPerformedAtTime = log[1];
            
            if (!userActiveMinutes.ContainsKey(userId))
            {
                userActiveMinutes[userId] = new HashSet<int>();
            }
            
            userActiveMinutes[userId].Add(taskPerformedAtTime);
        }

        int[] result = new int[k];
        foreach (var (userId, totalTimeTaken) in userActiveMinutes)
        {
            result[totalTimeTaken.Count - 1]++;
        }

        return result;
    }
}