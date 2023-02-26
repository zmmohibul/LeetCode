using System.Text;

namespace SimplifyPath;

public class Solution
{
    public string SimplifyPath(string path)
    {
        var sb = new StringBuilder(path);
        sb.Append('/');
        
        //remove ./
        for (int i = 1; i < sb.Length - 1; i++)
        {
            if (sb[i] == '.' && sb[i - 1] != '.' && sb[i + 1] == '/')
            {
                if (i > 0 && sb[i-1]!='/') continue;
                sb.Remove(i, 1);
                i--;
            }
        }
        
        //remove extra slashes
        for (int i = 1; i < sb.Length; i++)
        {
            if (sb[i] == '/' && sb[i - 1] == '/')
            {
                sb.Remove(i, 1);
                i--;
            }
        }

        
        // remove ../
        for (int i = 0; i < sb.Length - 2; i++)
        {
            if (sb[i] == '.' && sb[i + 1] == '.' && sb[i + 2] == '/')
            {
                if (i > 0 && sb[i-1]=='.') continue;
                if (i > 0 && sb[i-1]!='/') continue;


                int j = i - 2;
                if (j < 0)
                {
                    sb.Remove(i, 3);
                    i--;
                }
                else
                {
                    while (sb[j] != '/')
                    {
                        j--;
                    }

                    var s = i - j + 2;
                    sb.Remove(j, s);
                    i = j;
                }
            }
        }

        

        if (sb.Length > 1 && sb[sb.Length - 1] == '/')
        {
            sb.Remove(sb.Length - 1, 1);
        }
        return sb.ToString();
    }
}