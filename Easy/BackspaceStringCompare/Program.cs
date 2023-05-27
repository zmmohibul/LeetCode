using BackspaceStringCompare;

var sl = new Solution();
Console.WriteLine(sl.BackspaceCompare("ab##", "c#d#"));
Console.WriteLine(sl.BackspaceCompare("#kab##", "kc#d#"));
Console.WriteLine(sl.BackspaceCompare("a#c", "b"));
Console.WriteLine(sl.BackspaceCompare("a#c", "c"));