using System.Text;

namespace SortCharactersByFrequency;

public class Solution
{
    public static string FrequencySort(string s)
    {
        var sFreq = new Dictionary<char, int>();
        foreach (var c in s)
        {
            sFreq[c] = sFreq.GetValueOrDefault(c, 0) + 1;
        }

        var pq = new PriorityQueue<char, int>(new IntMaxCompare());
        foreach (var (c, count) in sFreq)
        {
            Console.Write($"{c} - {count}, ");
            pq.Enqueue(c, count);
        }

        Console.WriteLine(pq.Count);

        var result = new StringBuilder();
        var pqC = pq.Count;
        for (int i = 0; i < pqC; i++)
        {
            var element = pq.Dequeue();
            var elementCount = sFreq[element];
            Console.Write($"{element} - {elementCount}, ");
            for (int j = 0; j < elementCount; j++)
            {
                result.Append(element);
            }
        }

        Console.WriteLine();

        return result.ToString();
    }
}

public class IntMaxCompare : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y.CompareTo(x);
    }
}