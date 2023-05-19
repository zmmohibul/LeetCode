using System.Text;

namespace OccurrencesAfterBigram;

public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
        var wordsInText = new List<StringBuilder>();
        var i = 0;
        while (i < text.Length)
        {
            var sb = new StringBuilder();
            while (i < text.Length && text[i] != ' ')
            {
                sb.Append(text[i]);
                i++;
            }

            wordsInText.Add(sb);
            i++;
        }
        
        wordsInText.ForEach(Console.WriteLine);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        var result = new List<string>();
        i = 0;
        while (i < wordsInText.Count)
        {
            if (wordsInText[i].Length == first.Length)
            {
                var k = i;
                var firstMatch = true;
                for (int j = 0; j < wordsInText[k].Length; j++)
                {
                    if (wordsInText[k][j] != first[j])
                    {
                        firstMatch = false;
                        break;
                    }
                }

                var secondMatch = true;
                if (firstMatch)
                {
                    k++;
                    if (k < wordsInText.Count && wordsInText[k].Length == second.Length)
                    {
                        for (int j = 0; j < wordsInText[k].Length; j++)
                        {
                            if (wordsInText[k][j] != second[j])
                            {
                                secondMatch = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        secondMatch = false;
                    }
                }
                
                
                if (firstMatch && secondMatch && (k + 1) < wordsInText.Count)
                {
                    k++;
                    Console.WriteLine($"{firstMatch} - {secondMatch}");
                    Console.WriteLine($"{i} - {k} - {wordsInText[k]}");
                    result.Add(wordsInText[k].ToString());
                }
            }

            i++;
        }
        //
        // i = 0;
        // while (i < wordsInText.Count)
        // {
        //     var word = wordsInText[i];
        //     if (word.Length == first.Length)
        //     {
        //         var k = i;
        //         if (word.Equals(first))
        //         {
        //             k++;
        //             word = wordsInText[k];
        //             if (word.Length == second.Length)
        //             {
        //                 if (word.Equals(second))
        //                 {
        //                     k++;
        //                     result.Add(wordsInText[k]);
        //                 }
        //             }
        //         }
        //     }
        //     i++;
        // }
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        return result.ToArray();
    }
}