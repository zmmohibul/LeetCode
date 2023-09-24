using LongestStringChain;

var sl = new Solution();

var words = new string[] {"a","b","ba","bca","bda","bdca"};
Console.WriteLine(sl.LongestStrChain(words));

words = new string[] {"a","b","ba","bca","bda","bdca","abcdefghijkl","abcdefghijk","abcdefghij","abcdefghi","abcdefgh","abcdefg","abcdef","abcde"};
Console.WriteLine(sl.LongestStrChain(words));
