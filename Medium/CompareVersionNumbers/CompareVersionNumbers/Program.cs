using CompareVersionNumbers;

var sl = new Solution();
Console.WriteLine(sl.CompareVersion("1.01", "1.001"));
Console.WriteLine(sl.CompareVersion("1.01", "1.001.0"));
Console.WriteLine(sl.CompareVersion("0.01", "1.001"));
Console.WriteLine(sl.CompareVersion("1.01", "1.0"));