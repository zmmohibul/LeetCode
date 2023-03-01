namespace MinimumAbsoluteDifference;

public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        int minDiff = int.MaxValue;
        // -46 -24 -5 2 34 60
        for (int i = 1; i < arr.Length; i++)
        {
            var n2 = arr[i];
            var n1 = arr[i - 1];
            int diff = 0;
            if (n1 <= 0 && n2 <= 0)
            {
                diff = Math.Abs(Math.Abs(n2) - Math.Abs(n1));
            }
            else if (n1 >= 0 && n2 >= 0)
            {
                diff = n2 - n1;
            }
            else if (n1 <= 0 && n2 > 0)
            {
                n1 = Math.Abs(n1);
                diff = n1 + n2;
            }

            if (diff < minDiff)
            {
                minDiff = diff;
            }
        }

        var result = new List<IList<int>>();
        for (int i = 1; i < arr.Length; i++)
        {
            var n2 = arr[i];
            var n1 = arr[i - 1];
            int diff = 0;
            if (n1 <= 0 && n2 <= 0)
            {
                diff = Math.Abs(Math.Abs(n2) - Math.Abs(n1));
            }
            else if (n1 >= 0 && n2 >= 0)
            {
                diff = n2 - n1;
            }
            else if (n1 <= 0 && n2 > 0)
            {
                n1 = Math.Abs(n1);
                diff = n1 + n2;
            }

            if (diff == minDiff)
            {
                result.Add(new List<int>() { Math.Min(arr[i], arr[i - 1]), Math.Max(arr[i], arr[i - 1]) });
            }
        }

        return result;
    }
}