namespace CombinationSum;

public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
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
            for (int i = start; i < candidates.Length; i++)
            {
                currList.AddLast(candidates[i]);
                CombinationSum(candidates, target, currSum + candidates[i], i, result, currList);
                currList.RemoveLast();
            }
        }
    }
}