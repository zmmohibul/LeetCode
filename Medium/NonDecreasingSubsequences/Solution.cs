using System.Text;

namespace NonDecreasingSubsequences;

public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            var newResult = new List<IList<int>>();
            foreach (var item in result)
            {
                if (nums[i] >= item[^1])
                {
                    var newItem = new List<int>(item);
                    newItem.Add(nums[i]);
                    newResult.Add(item);
                    newResult.Add(newItem);
                }
                else
                {
                    newResult.Add(item);
                }

            }

            newResult.Add(new List<int>{ nums[i] });
            result = newResult;
        }

        var output = new List<IList<int>>();
        var hs = new HashSet<string>();
        foreach (var item in result)
        {
            if (item.Count > 1)
            {
                var arr = new int[202];
                foreach (var num in item)
                {
                    if (num < 0)
                    {
                        arr[num * -1]++;
                    }
                    else if (num > 0)
                    {
                        arr[num + 100]++;
                    }
                    else
                    {
                        arr[0]++;
                    }
                }

                var sb = new StringBuilder();
                foreach (var num in arr)
                {
                    sb.Append($"#{num}");
                }
                
                var sbStr = sb.ToString();
                if (!hs.Contains(sbStr))
                {
                    output.Add(item);
                    hs.Add(sbStr);
                }
            }
        }

        return output;
    }
}