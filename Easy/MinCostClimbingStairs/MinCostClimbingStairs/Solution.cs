namespace MinCostClimbingStairs;

public class Solution {
    private Dictionary<int, int> cache = new Dictionary<int, int>();
    public int MinCostClimbingStairs(int[] cost) {
        return MinCostClimbingStairsRec(cost, -1);
    }

    public int MinCostClimbingStairsRec(int[] cost, int i) {
        if (cache.ContainsKey(i))
        {
            return cache[i];
        }

        if (i >= cost.Length - 2)
        {
            return 0;
        }

        var costAtOneStep = cost[i + 1] + MinCostClimbingStairsRec(cost, i + 1);
        var costAtTwoStep = cost[i + 2] + MinCostClimbingStairsRec(cost, i + 2);
        
        var minCost = Math.Min(costAtOneStep, costAtTwoStep);
        cache[i] = minCost;
        
        return minCost;
    }
}