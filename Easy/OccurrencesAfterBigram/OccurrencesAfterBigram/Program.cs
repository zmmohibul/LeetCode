// See https://aka.ms/new-console-template for more information

using OccurrencesAfterBigram;


var sl = new Solution();
// sl.FindOcurrences("alice is a good girl she is a good student", "a", "good").ToList().ForEach(Console.WriteLine);
sl.FindOcurrences("jkypmsxd jkypmsxd kcyxdfnoa jkypmsxd kcyxdfnoa jkypmsxd kcyxdfnoa kcyxdfnoa jkypmsxd kcyxdfnoa", "kcyxdfnoa", "jkypmsxd").ToList().ForEach(Console.WriteLine);