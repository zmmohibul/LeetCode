namespace CheckIfItIsStraightLine;

public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        double x = coordinates[1][0] - coordinates[0][0];
        double y = coordinates[1][1] - coordinates[0][1];
        double m;
        if (x == 0)
        {
            m = 0;
        }
        else
        {
            m = y / x;
        }
        
        for(int i = 0; i < coordinates.Length - 1; i++) {
            double dx = coordinates[i + 1][0] - coordinates[i][0];
            double dy = coordinates[i + 1][1] - coordinates[i][1];
            
            double slope;
            if (dx == 0)
            {
                slope = 0;
            }
            else
            {
                slope = dy / dx;
            }

            if (slope != m)
            {
                return false;
            }
        }
        return true;
    }
}