namespace ImageSmoother;

public class Solution {
    public int[][] ImageSmoother(int[][] img) {
        int[][] answer = new int[img.Length][];
        for (int row = 0; row < img.Length; row++)
        {
            
            answer[row] = new int[img[row].Length];

            for (int col = 0; col < img[row].Length; col++)
            {
                var neighborSum = img[row][col];
                var neighborCount = 1;
                
                if (row - 1 > -1)
                {
                    neighborSum += img[row - 1][col];
                    neighborCount++;
                }

                if (row + 1 < img.Length)
                {
                    neighborSum += img[row + 1][col];
                    neighborCount++;
                }

                if (col - 1 > -1)
                {
                    neighborSum += img[row][col - 1];
                    neighborCount++;
                }

                if (col + 1 < img[row].Length)
                {
                    neighborSum += img[row][col + 1];
                    neighborCount++;
                }

                if (row - 1 > -1 && col - 1 > -1)
                {
                    neighborSum += img[row - 1][col - 1];
                    neighborCount++;
                }

                if (row - 1 > -1 && col + 1 < img[row].Length)
                {
                    neighborSum += img[row - 1][col + 1];
                    neighborCount++;
                }

                if (row + 1 < img.Length && col - 1 > -1)
                {
                    neighborSum += img[row + 1][col - 1];
                    neighborCount++;
                }

                if (row + 1 < img.Length && col + 1 < img[row].Length)
                {
                    neighborSum += img[row + 1][col + 1];
                    neighborCount++;
                }

                answer[row][col] = neighborSum / neighborCount;
            }
        }

        return answer;
    }
}