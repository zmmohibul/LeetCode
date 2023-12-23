namespace PathCrossing;

public class Solution {
    public bool IsPathCrossing(string path) {
        var points = new HashSet<Tuple<int, int>>();
        points.Add(new Tuple<int, int>(0, 0));
        
        int vPoint = 0, hPoint = 0;
        foreach (var d in path)
        {
            if (d == 'N') vPoint++;
            if (d == 'S') vPoint--;
            if (d == 'E') hPoint++;
            if (d == 'W') hPoint--;
            
            var tuple = new Tuple<int, int>(vPoint, hPoint);
            if (points.Contains(tuple))
            {
                return true;
            }
            
            points.Add(tuple);
        }

        return false;
    }
}