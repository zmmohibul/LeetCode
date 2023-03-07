using System.Text;

namespace DefangingIPAddress;

public class Solution
{
    public string DefangIPaddr(string address) 
    {
        var sb = new StringBuilder(address);
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == '.')
            {
                sb.Insert(i, '[');
                i++;
                sb.Insert(i + 1, ']');
                i++;
            }
        }

        return sb.ToString();
    }
}