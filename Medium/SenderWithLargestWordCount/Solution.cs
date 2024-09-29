namespace SenderWithLargestWordCount;

public class Solution
{
    public string LargestWordCount(string[] messages, string[] senders) 
    {
        var userWordCount = new Dictionary<string, int>();
        for (int i = 0; i < messages.Length; i++)
        {
            var message = messages[i];

            var wordCount = 1;
            for (int j = 0; j < message.Length; j++)
            {
                if (message[j] == ' ')
                {
                    wordCount++;
                }
            }

            userWordCount[senders[i]] = userWordCount.GetValueOrDefault(senders[i]) + wordCount;
        }

        var maxWordCount = userWordCount.Values.Max();
        var users = new List<string>();
        foreach (var (user, wordCount) in userWordCount)
        {
            if (wordCount == maxWordCount)
            {
                users.Add(user);
            }
        }
        users.Sort(new LexComparer());

        return users[0];
    }
}

public class LexComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        if (String.Compare(x, y, StringComparison.Ordinal) > 0)
            return -1;
        return 1;
    }
}