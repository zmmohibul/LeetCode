using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationInString
{
    public class Solution
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s2.Length < s1.Length)
            {
                return false;
            }

            Dictionary<char, int> s1Freq = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                s1Freq[s1[i]] = s1Freq.GetValueOrDefault(s1[i], 0) + 1;
            }

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1Freq.ContainsKey(s2[i]))
                {
                    s1Freq[s2[i]] -= 1;
                }
            }

            int k = 0;
            int j = s1.Length - 1;
            while (true)
            {
                bool hasPermutation = true;

                for (int index = 0; index < s1Freq.Count; index++)
                {
                    if (s1Freq.ElementAt(index).Value > 0)
                    {
                        hasPermutation = false;
                        break;
                    }
                }

                if (hasPermutation)
                {
                    return true;
                }

                if (s1Freq.ContainsKey(s2[k]))
                {
                    s1Freq[s2[k]] += 1;
                }
                k += 1;

                j += 1;
                if (j >= s2.Length)
                {
                    break;
                }

                if (s1Freq.ContainsKey(s2[j]))
                {
                    s1Freq[s2[j]] -= 1;
                }
            }

            return false;

        }
    }
}
