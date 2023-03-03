namespace GroupPeopleGivenGroupSizeTheyBelongTo;

public class Solution
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        var groupsList = new Dictionary<int, IList<int>>();
        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (!groupsList.ContainsKey(groupSizes[i]))
            {
                groupsList[groupSizes[i]] = new List<int>();
            }
            
            groupsList[groupSizes[i]].Add(i);
        }

        var result = new List<IList<int>>();
        foreach (var (key, value) in groupsList)
        {
            var groupNo = value.Count / key;
            for (int i = 0; i < groupNo; i++)
            {
                var subRes = new List<int>();
                for (int j = i * key; j < (i * key) + key; j++)
                {
                    subRes.Add(value[j]);
                }

                result.Add(subRes);
            }
        }

        return result;


    }
}