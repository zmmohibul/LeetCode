namespace Permutations;

public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        return Permute(nums.ToList());
    }

    public IList<IList<int>> Permute(List<int> sub)
    {
        if (sub.Count == 1)
        {
            return new List<IList<int>>(){new List<int>(){sub[0]}};
        }
        else
        {
            var result = new List<IList<int>>();

            for (int i = 0; i < sub.Count; i++)
            {
                var rem = new List<int>();
                for (int j = 0; j < sub.Count; j++)
                {
                    if (j != i)
                    {
                        rem.Add(sub[j]);
                    }
                }

                var remPermute = Permute(rem);
                foreach (var item in remPermute)
                {
                    item.Add(sub[i]);
                    result.Add(item);
                }


            }
            return result;

        }
    }
}