namespace CombinationSumIII;

public class Solution {
    private List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> CombinationSum3(int k, int n) {
        FindSum(k, n, 1, new List<int>());
        return result;
    }

    public void FindSum(int k, int n, int li, List<int> chosen)
    {
        if (n == 0 && chosen.Count == k)
        {
            result.Add(new List<int>(chosen));
        }

        if (n <= 0)
        {
            return;
        }

        if (chosen.Count > 0 && chosen[^1] > n)
        {
            return;
        }

        for (int i = li; i <= 9; i++)
        {
            chosen.Add(i);
            FindSum(k, n - i, i + 1, chosen);
            chosen.RemoveAt(chosen.Count - 1);
        }
    }
}