namespace FindingTheUsersActiveMinutes;

public class Solution
{
    public int[] FindingUsersActiveMinutes(int[][] logs, int k)
    {
        var userActiveMinutes = new Dictionary<int, HashSet<int>>();
        for (int i = 0; i < logs.Length; i++)
        {
            var curLogId = logs[i][0];
            var curLogTime = logs[i][1];
            if (!userActiveMinutes.ContainsKey(curLogId))
            {
                userActiveMinutes[curLogId] = new HashSet<int>();
            }

            userActiveMinutes[curLogId].Add(curLogTime);
        }

        int[] result = new int[k];
        for (int index = 0; index < userActiveMinutes.Count; index++) {
            var item = userActiveMinutes.ElementAt(index);
            var userId = item.Key;
            var totalTime = item.Value.Count;
            
            if (totalTime <= k)
            {
                result[totalTime - 1]++;
            }
        }

        return result;
    }
}