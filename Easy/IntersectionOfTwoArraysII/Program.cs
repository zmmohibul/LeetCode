namespace IntersectionOfTwoArraysII;

class Program
{
    static void Main(string[] args)
    {
        var arr1 = new int[] { 4, 9, 5 };
        var arr2 = new int[] { 9, 4, 9, 8, 4 };
        
        var sl = new Solution();
        var intersection = sl.Intersect(arr1, arr2);
        foreach (var n in intersection)
        {
            Console.Write($"{n}, ");
        }

        Console.WriteLine();
    }
}