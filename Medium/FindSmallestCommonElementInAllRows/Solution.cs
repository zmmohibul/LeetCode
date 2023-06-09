namespace FindSmallestCommonElementInAllRows;

public class Solution 
{
    public int SmallestCommonElement(int[][] mat) 
    {
        var elementFreq = new Dictionary<int, int>();
        for (int i = 0; i < mat.Length; i++)
        {
            var row = mat[i];
            var elementsInRow = new HashSet<int>();
            
            for (int j = 0; j < row.Length; j++)
            {
                if (!elementsInRow.Contains(row[j]))
                {
                    elementFreq[row[j]] = elementFreq.GetValueOrDefault(row[j], 0) + 1;
                }

                elementsInRow.Add(row[j]);
            }
        }

        for (int i = 0; i < elementFreq.Count; i++)
        {
            var item = elementFreq.ElementAt(i);
            var element = item.Key;
            var count = item.Value;

            if (count == mat.Length)
            {
                return element;
            }
        }

        return -1;
    }
}