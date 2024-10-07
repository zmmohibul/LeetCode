using PositionsOfLargeGroups;

var sl = new Solution();
var groups = sl.LargeGroupPositions("aaaaaaabbbbbbbbbbbbccddddddddeejjjjjjj");
foreach (var group in groups)
{
    Console.WriteLine($"({group[0]}, {group[1]})");
}
