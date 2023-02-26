using SimplifyPath;

var sl = new Solution();
Console.WriteLine(sl.SimplifyPath("/a//b///c////d/////"));
Console.WriteLine(sl.SimplifyPath("/a//b///c////d/////./e/../f"));
Console.WriteLine(sl.SimplifyPath("/a//b///c////d/////./e/../////f/../..////j/./k/./l/.////..///m"));
Console.WriteLine(sl.SimplifyPath("/a//b///c////d/////./e/../////f/../..////j/./k/./l/.////..///m/...mo/.....poi/"));
Console.WriteLine(sl.SimplifyPath("/a/b/c/d/./e/../f/../../j/./k/./l/./../m/...mo/.....poi/"));