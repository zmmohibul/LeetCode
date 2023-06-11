namespace RelativeRanks;

public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < score.Length; i++)
        {
            pq.Enqueue(i, score[i]);
        }

        var pos = score.Length;
        var result = new string[score.Length];
        while (pq.Count > 3)
        {
            result[pq.Dequeue()] = $"{pos}";
            pos--;
        }

        pos = pq.Count;

        var dict = new Dictionary<int, string>
        {
            {1, "Gold Medal"},
            {2, "Silver Medal"},
            {3, "Bronze Medal"},
        };

        while (pq.Count > 0)
        {
            result[pq.Dequeue()] = $"{dict[pos]}";
            pos--;
        }

        return result;
    }
}