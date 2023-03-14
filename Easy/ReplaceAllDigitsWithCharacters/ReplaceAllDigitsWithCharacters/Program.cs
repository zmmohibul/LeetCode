// See https://aka.ms/new-console-template for more information

using ReplaceAllDigitsWithCharacters;

var c = 'a';
int i = c;
Console.WriteLine($"{c} - {i}");

i += 5;
c = (char) i;
Console.WriteLine($"{c} - {i}");

var sl = new Solution();
Console.WriteLine(sl.ReplaceDigits("a1c1e1"));
Console.WriteLine(sl.ReplaceDigits("a1b2c3d4e"));