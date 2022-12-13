namespace RelativeSortArray;

public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var arr2hs = new HashSet<int>();
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2hs.Add(arr2[i]);
        }

        var pq = new PriorityQueue<int, int>();
        var arr1Freq = new Dictionary<int, int>();
        for (int i = 0; i < arr1.Length; i++)
        {
            if (!arr2hs.Contains(arr1[i]))
            {
                pq.Enqueue(arr1[i], arr1[i]);
            }
            arr1Freq[arr1[i]] = arr1Freq.GetValueOrDefault(arr1[i], 0) + 1;
        }

        var a = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            var n = arr2[i];
            var nCount = arr1Freq[n];
            for (int j = 0; j < nCount; j++)
            {
                arr1[a] = n;
                a += 1;
            }
            arr1Freq.Remove(n);
        }

        while (pq.Count > 0)
        {
            arr1[a] = pq.Dequeue();
            a += 1;
        }

        return arr1;
    }
}