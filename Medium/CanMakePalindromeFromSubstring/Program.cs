var s = "abcda";
var queries = new int[][]
{
    new int [] { 3, 3, 0 },
    new int [] { 1, 2, 0 },
    new int [] { 0, 3, 1 },
    new int [] { 0, 3, 2 },
    new int [] { 0, 4, 1 }
};
var solution = new Solution();
var result = solution.CanMakePaliQueries(s, queries);
foreach (var r in result)
{
    Console.Write($"{r}, ");
}