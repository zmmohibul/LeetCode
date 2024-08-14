namespace FindTheNumberOfWinningPlayers;

public class Solution {
    public int WinningPlayerCount(int n, int[][] pick)
    {
        var map = new Dictionary<int, Dictionary<int, int>>();
        foreach (var p in pick)
        {
            var player = p[0];
            var color = p[1];
            if (!map.ContainsKey(player))
            {
                map[player] = new();
            }

            var colMap = map[player];
            colMap[color] = colMap.GetValueOrDefault(color) + 1;
        }

        var winnerCount = 0;
        foreach (var (player, colorCountMap) in map)
        {
            if (colorCountMap.Values.Any(colorCount => colorCount > player))
            {
                winnerCount++;
            }
        }

        return winnerCount;
    }
}