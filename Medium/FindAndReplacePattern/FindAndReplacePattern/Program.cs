// See https://aka.ms/new-console-template for more information

using FindAndReplacePattern;

var sl = new Solution();
Console.WriteLine(sl.DoesPatternMatch("mee", "abb"));
Console.WriteLine(sl.DoesPatternMatch("ced", "abb"));
Console.WriteLine(sl.DoesPatternMatch("baa", "abb"));