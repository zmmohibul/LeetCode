namespace SpecialPositionsInBinaryMatrix;

public class Solution {
    public int NumSpecial(int[][] mat) {
        var rowFreq = new Dictionary<int, int>();
        var columnFreq = new Dictionary<int, int>();
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (!rowFreq.ContainsKey(i))
                {
                    rowFreq[i] = 0;
                }

                if (!columnFreq.ContainsKey(j))
                {
                    columnFreq[j] = 0;
                }

                if (mat[i][j] == 1)
                {
                    rowFreq[i]++;
                    columnFreq[j]++;
                }
            }
        }

        var count = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1 && rowFreq[i] == 1 && columnFreq[j] == 1)
                {
                    count++;
                }
            }
        }

        return count;
    }
}