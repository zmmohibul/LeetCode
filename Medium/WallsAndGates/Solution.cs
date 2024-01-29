namespace WallsAndGates;

public class Solution {
    private readonly HashSet<Tuple<int, int>> roomTuples = new();
    private readonly HashSet<Tuple<int, int>> gates = new();
    private HashSet<Tuple<int, int>> nexLevelQueue = new();
    private readonly HashSet<Tuple<int, int>> visited = new();
    private int[][] rooms;
    public void WallsAndGates(int[][] rooms)
    {
        this.rooms = rooms;
        for (var row = 0; row < rooms.Length; row++)
        {
            for (var col = 0; col < rooms[0].Length; col++)
            {
                var tuple = new Tuple<int, int>(row, col);
                if (rooms[row][col] == 0)
                {
                    gates.Add(tuple);
                }
                else if (rooms[row][col] == 2147483647)
                {
                    roomTuples.Add(tuple);
                }
            }
        }

        var queue = new HashSet<Tuple<int, int>>();
        foreach (var gate in gates)
        {
            queue.Add(gate);
        }
        
        var level = 1;
        while (queue.Count > 0)
        {
            var newQueue = new HashSet<Tuple<int, int>>();
            for (var i = 0; i < queue.Count; i++)
            {
                var u = queue.ElementAt(i);
                visited.Add(u);

                var uRow = u.Item1;
                var uCol = u.Item2;
                
                var top = new Tuple<int, int>(uRow + 1, uCol);
                CheckRoomTuple(top, level);
                
                var bottom = new Tuple<int, int>(uRow - 1, uCol);
                CheckRoomTuple(bottom, level);

                var right = new Tuple<int, int>(uRow, uCol + 1);
                CheckRoomTuple(right, level);

                var left = new Tuple<int, int>(uRow, uCol - 1);
                CheckRoomTuple(left, level);
            }

            level++;
            queue = nexLevelQueue;
            nexLevelQueue = new();
        }
    }

    private void CheckRoomTuple(Tuple<int, int> tuple, int level)
    {
        if (roomTuples.Contains(tuple))
        {
            rooms[tuple.Item1][tuple.Item2] = level;
            roomTuples.Remove(tuple);
            
            if (!visited.Contains(tuple))
            {
                nexLevelQueue.Add(tuple);
            }
        }
    }
}