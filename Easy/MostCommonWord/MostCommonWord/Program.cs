using MostCommonWord;

var sl = new Solution();

var paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
var banned = new string[] { "hit" };
Console.WriteLine(sl.MostCommonWord(paragraph, banned));

paragraph = "Bob. hIt, baLl";
banned = new string[] { "bob", "hit" };
Console.WriteLine(sl.MostCommonWord(paragraph, banned));