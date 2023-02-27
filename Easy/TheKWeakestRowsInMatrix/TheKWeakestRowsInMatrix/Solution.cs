namespace TheKWeakestRowsInMatrix;

public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        var pq = new PriorityQueue<int, int>();
        var seen = new HashSet<int>();
        var dups = new HashSet<int>();
        for (int i = 0; i < mat.Length; i++)
        {
            var soldierCount = 0;
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1)
                {
                    soldierCount++;
                }
            }

            if (seen.Contains(soldierCount))
            {
                dups.Add(soldierCount);
            }
            else
            {
                seen.Add(soldierCount);
            }

            pq.Enqueue(i, soldierCount);
        }

        var result = new int[k];
        for (int i = 0; i < k; i++)
        {
            var ind = 0;
            var value = 0;
            pq.TryDequeue(out ind, out value);
            
            if (dups.Contains(value))
            {
                var dupPq = new PriorityQueue<int, int>();

                var innerInd = ind;
                var innerValue = value;

                do
                {
                    dupPq.Enqueue(innerInd, innerInd);
                    pq.TryDequeue(out innerInd, out innerValue);
                    
                }
                while (innerValue == value) ;
                
                pq.Enqueue(innerInd, innerValue);

                while (dupPq.Count > 0 && i < k)
                {
                    result[i] = dupPq.Dequeue();
                    i++;
                }
                if (i == k)
                {
                    break;
                }
                else
                {
                    i--;
                }
            }
            else
            {
                result[i] = ind;
            }
        }

        return result;
    }
}

public class IntMaxCompare : IComparer<int>
{
    public int Compare(int x, int y) => y.CompareTo(x);
}