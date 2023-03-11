using System.Text;

namespace SortingTheSentence;

public class Solution
{
    public string SortSentence(string s)
    {
        var hs = new HashSet<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        var pq = new PriorityQueue<string, int>();
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (hs.Contains(s[i]))
            {
                pq.Enqueue(sb.ToString(), Convert.ToInt32(s[i]));
                sb = new StringBuilder();
                i++;
            }
            else
            {
                sb.Append(s[i]);
            }
        }

        while (pq.Count > 0)
        {
            sb.Append(pq.Dequeue());
            sb.Append(' ');
        }

        sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }
}