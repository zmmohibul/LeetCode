using MinimumAddToMakeParenthesesValid;

var sl = new Solution();

Console.WriteLine(sl.MinAddToMakeValid("())"));
Console.WriteLine(sl.MinAddToMakeValid("((("));
Console.WriteLine(sl.MinAddToMakeValid("()))(("));
Console.WriteLine(sl.MinAddToMakeValid("((()()((())))((()())(((((()))))))))))(((((((((((((((((((((((())"));