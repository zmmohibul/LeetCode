namespace LargestValuesFromLabels;

public class Solution {
    public int LargestValsFromLabels(int[] values, int[] labels, int numWanted, int useLimit) {
        var valueLabelMap = new Dictionary<int, List<int>>();
        for (int i = 0; i < values.Length; i++)
        {
            if (!valueLabelMap.ContainsKey(values[i]))
            {
                valueLabelMap[values[i]] = new List<int>();
            }

            valueLabelMap[values[i]].Add(labels[i]);
        }

        var valueSet = new SortedSet<int>(values, new IntMaxCompare());
        var lableFreq = new Dictionary<int, int>();
        int sum = 0, count = 0;
        foreach (var value in valueSet)
        {
            var labelsForValue = valueLabelMap[value];
            foreach (var label in labelsForValue)
            {
                var t = new Tuple<int, int>(value, label);
                if (lableFreq.GetValueOrDefault(label) < useLimit)
                {
                    lableFreq[label] = lableFreq.GetValueOrDefault(label) + 1;
                    sum += value;
                    
                    count++;
                    if (count == numWanted) break;
                }
            }

            if (count == numWanted) break;
        }

        return sum;
    }

    public class IntMaxCompare : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}