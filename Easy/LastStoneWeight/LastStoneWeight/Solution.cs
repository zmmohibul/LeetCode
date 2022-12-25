namespace LastStoneWeight;

public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var pq = new PriorityQueue<int, int>(new IntMaxCompare());
        for (int i = 0; i < stones.Length; i++)
        {
            pq.Enqueue(stones[i], stones[i]);
        }

        while (pq.Count > 1)
        {
            int y = pq.Dequeue();
            int x = pq.Dequeue();
            int d = y - x;

            if (d > 0)
            {
                pq.Enqueue(d, d);
            }
        }

        return pq.Count > 0 ? pq.Dequeue() : 0;
    }
}

public class IntMaxCompare : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y.CompareTo(x);
    }
}