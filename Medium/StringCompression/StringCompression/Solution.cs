namespace StringCompression;

public class Solution
{
    public int Compress(char[] chars)
    {
        int j = 0;
        int k = 0;
        int count = 0;
        char last = chars[0];
        while (j <= chars.Length)
        {
            if (j == chars.Length || chars[j] != chars[k])
            {
                if (count == 1)
                {
                    k += 1;
                }
                else if (count < 10)
                {
                    k += 1;
                    chars[k] = (char)(count + 48);
                    k += 1;
                }
                else
                {
                    var countList = new List<int>();
                    while (count > 0)
                    {
                        countList.Add(count % 10);
                        count /= 10;
                    }
                    
                    k += 1;
                    for (int l = countList.Count - 1; l > -1; l--)
                    {
                        chars[k] = (char)(countList[l] + 48);
                        k += 1;
                    }
                }
                
                if (j == chars.Length)
                {
                    break;
                }
                
                chars[k] = chars[j];
                count = 1;
            }
            else if (chars[j] == chars[k])
            {
                count += 1;
            }
            
            
                


            j++;
        }

        return k;
    }
}