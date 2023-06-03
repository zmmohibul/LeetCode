namespace MinimumNumberOfOperationsToMoveAllBallsToEachBox;

public class Solution
{
    public int[] MinOperations(string boxes)
    {
        // "110"
        // [1,1,3]
        
        // 0 0 1 0 1 1
        //         i
        var ballCount = 0;
        var operations = 0;
        var answers = new int[boxes.Length];
        for (int i = 0; i < boxes.Length; i++)
        {
            answers[i] += operations;

            if (boxes[i] == '1')
            {
                ballCount++;
            }

            operations += ballCount;
        }

        ballCount = 0;
        operations = 0;
        for (int i = boxes.Length - 1; i > -1; i--)
        {
            answers[i] += operations;

            if (boxes[i] == '1')
            {
                ballCount++;
            }

            operations += ballCount;
        }

        return answers;
    }
}