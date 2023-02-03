using System.Text;

namespace ZigzagConversion;

public class Solution
{
    public static string Convert(string s, int numRows)
    {
        if (numRows < 2)
        {
            return s;
        }

        var sb = new StringBuilder();
        var mat = new char[numRows][];
        int diagonal = numRows - 2;
        var colNo = (s.Length / numRows) + 1;
        colNo += (diagonal * colNo);
        if (colNo < 1)
        {
            colNo = numRows;
        }
        // Console.WriteLine($"Columns: {colNo}  - Diagonal: {diagonal}");

        for (int i = 0; i < numRows; i++)
        {
            mat[i] = new char[colNo];
        }

        int si = 0;
        for (int col = 0; col < colNo; col++)
        {
            for (int row = 0; row < numRows; row++)
            {
                mat[row][col] = s[si];
                si++;
                if (si == s.Length)
                {
                    break;
                }
            }
            
            if (si == s.Length)
            {
                break;
            }

            int r = numRows - 1;
            for (int d = 0; d < diagonal; d++)
            {
                r--;
                col++;
                mat[r][col] = s[si];
                si++;
                if (si == s.Length)
                {
                    break;
                }
            }
            
            if (si == s.Length)
            {
                break;
            }
        }

        sb = new StringBuilder();
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < colNo; col++)
            {
                // Console.Write($"{mat[row][col]} ");
                if (mat[row][col] != '\0')
                {
                    sb.Append(mat[row][col]);
                }
            }

            // Console.WriteLine();
        }

        


        return sb.ToString();
    }
}