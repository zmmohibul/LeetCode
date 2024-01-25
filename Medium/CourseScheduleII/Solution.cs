namespace CourseScheduleII;

public class Solution 
{
    public int[] FindOrder(int numCourses, int[][] prerequisites) 
    {
        var graph = new DirectedGraph(numCourses, prerequisites);
        return graph.GetTopologicalSortedOrder();
    }
}