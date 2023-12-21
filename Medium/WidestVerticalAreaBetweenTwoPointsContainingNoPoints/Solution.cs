namespace WidestVerticalAreaBetweenTwoPointsContainingNoPoints;

public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        var xPointSet = new SortedSet<int>();
        foreach (var point in points)
        {
            if (point[1] != 0)
            {
                xPointSet.Add(point[0]);
            }
        }

        var max = 0;
        var lastX = xPointSet.First();
        xPointSet.Remove(lastX);
        foreach (var x in xPointSet)
        {
            var area = x - lastX;
            if (area > max) max = area;
            lastX = x;
        }

        return max;
    }
}