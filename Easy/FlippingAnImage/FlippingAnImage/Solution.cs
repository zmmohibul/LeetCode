namespace FlippingAnImage;

public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        for (int i = 0; i < image.Length; i++)
        {
            var row = image[i];
            int j = 0;
            int k = row.Length - 1;
            while (j < k)
            {
                if (row[j] == 0)
                {
                    row[j] = 1;
                }
                else
                {
                    row[j] = 0;
                }

                if (row[k] == 0)
                {
                    row[k] = 1;
                }
                else
                {
                    row[k] = 0;
                }

                (row[j], row[k]) = (row[k], row[j]);
                j++;
                k--;
            }
            
            if (j == k)
            {
                if (row[j] == 0)
                {
                    row[j] = 1;
                }
                else
                {
                    row[j] = 0;
                }
            }
        }

        return image;
    }
}