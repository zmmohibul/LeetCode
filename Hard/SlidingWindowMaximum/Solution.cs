namespace SlidingWindowMaximum;

public class Solution 
{
    public int[] MaxSlidingWindow(int[] nums, int k) 
    {
        var freq = new SortedDictionary<int, int>(new IntMaxComparer());
        for (int i = 0; i < k; i++)
        {
            var n = nums[i];
            freq[n] = freq.GetValueOrDefault(n, 0) + 1;
        }

        var result1 = new int[nums.Length - k + 1];
        var ri = 0;

        result1[ri] = freq.ElementAt(0).Key;
        ri++;


        var j = 0;
        for (int i = k; i < nums.Length; i++)
        {   
            var jn = nums[j];
            freq[jn] -= 1;
            if (freq[jn] == 0)
            {
                freq.Remove(jn);
            }

            var inm = nums[i];
            freq[inm] = freq.GetValueOrDefault(inm, 0) + 1;

            result1[ri] = freq.ElementAt(0).Key;
            ri++;

            j++;
        }   
        
        return result1;
    }

    public class IntMaxComparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}