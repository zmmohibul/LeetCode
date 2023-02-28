namespace CombinationSumII;

public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        CombinationSum(candidates, target, 0, 0, result, new LinkedList<int>());
        return result;
    }

    public void CombinationSum(int[] candidates, int target, int currSum, int start, IList<IList<int>> result, LinkedList<int> currList)
    {
        if (currSum == target)
        {
            result.Add(currList.ToList());
        }
        else if (currSum > target)
        {
            return;
        }
        else
        {
            var seen = new HashSet<int>();
            for (int i = start; i < candidates.Length; i++)
            {
                currList.AddLast(candidates[i]);
                if (!seen.Contains(candidates[i]))
                {
                    CombinationSum(candidates, target, currSum + candidates[i], i + 1, result, currList);
                }
                
                seen.Add(candidates[i]);
                currList.RemoveLast();
            }
        }
    }
}