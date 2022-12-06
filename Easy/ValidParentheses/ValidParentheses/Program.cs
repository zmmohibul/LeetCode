// See https://aka.ms/new-console-template for more information

using ValidParentheses;

Console.WriteLine(Solution.IsValid("()"));
Console.WriteLine(Solution.IsValid("(){}"));
Console.WriteLine(Solution.IsValid("(){]"));
Console.WriteLine(Solution.IsValid("([])({})"));
