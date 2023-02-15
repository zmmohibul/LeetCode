namespace TakeGiftsFromTheRichestPile;

public class Solution
{
    public long PickGifts(int[] gifts, int k)
    {
        var pq = new PriorityQueue<int, int>(new IntMaxComparer());
        for (int i = 0; i < gifts.Length; i++)
        {
            pq.Enqueue(i, gifts[i]);
        }

        for (int i = 0; i < k; i++)
        {
            var ind = pq.Dequeue();
            var val = (int) Math.Floor(Math.Sqrt(gifts[ind]));
            gifts[ind] = val;
            pq.Enqueue(ind, val);
        }

        long result = 0;
        for (int i = 0; i < gifts.Length; i++)
        {
            result += gifts[i];
        }

        return result;
    }
    
    public class IntMaxComparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}