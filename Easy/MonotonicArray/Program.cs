using MonotonicArray;

var sl = new Solution();

var nums = new int[] { 1, 2, 2, 3 };
Console.WriteLine(sl.IsMonotonic(nums));

nums = new int[] { 6, 5, 4, 4 };
Console.WriteLine(sl.IsMonotonic(nums));