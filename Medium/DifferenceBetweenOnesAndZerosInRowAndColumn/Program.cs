// See https://aka.ms/new-console-template for more information

using DifferenceBetweenOnesAndZerosInRowAndColumn;

var sl = new Solution();

int[][] grid = new int[3][]
{
    new int[] { 0, 1, 1 },
    new int[] { 1, 0, 1 },
    new int[] { 0, 0, 1 }
};

var result = sl.OnesMinusZeros(grid);
foreach (var row in result)
{
    foreach (var item in row)
    {
        Console.Write($"{item}, ");
    }
    Console.WriteLine();
}
