using System.Text;

namespace DecodeTheMessage;

public class Solution 
{
    public string DecodeMessage(string key, string message) 
    {
        var cipherMap = new Dictionary<char, char>();
        var c = 'a';
        for (int i = 0; i < key.Length; i++)
        {
            if (key[i] != ' ' && !cipherMap.ContainsKey(key[i]))
            {
                cipherMap[key[i]] = c;
                c++;
            }
        }
        cipherMap[' '] = ' ';

        var result = new StringBuilder();
        for (int i = 0; i < message.Length; i++)
        {
            result.Append(cipherMap[message[i]]);
        }

        return result.ToString();
        
    }
}