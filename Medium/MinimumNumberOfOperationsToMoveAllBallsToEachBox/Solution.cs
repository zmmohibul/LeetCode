namespace MinimumNumberOfOperationsToMoveAllBallsToEachBox;

public class Solution
{
    public int[] MinOperations(string boxes)
    {
        var answers = new int[boxes.Length];
        for (int i = 0; i < boxes.Length; i++)
        {
            var operations = 0;
            for (int j = 0; j < boxes.Length; j++)
            {
                if (boxes[j] == '1')
                {
                    operations += (Math.Abs(i - j));
                }
            }

            answers[i] = operations;
        }

        return answers;
    }
}