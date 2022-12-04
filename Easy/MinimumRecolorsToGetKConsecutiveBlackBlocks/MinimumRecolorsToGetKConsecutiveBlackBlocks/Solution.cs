using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumRecolorsToGetKConsecutiveBlackBlocks
{
    public class Solution
    {
        public static int MinimumRecolors(string blocks, int k)
        {
            // WBBWWBBWBW
            //  i      j           {B: 4, W: 3} min = 3

            // Iterate over block k times and build freq map
            var freq = new Dictionary<char, int>();
            for (int i = 0; i < k; i++)
            {
                freq[blocks[i]] = freq.GetValueOrDefault(blocks[i], 0) + 1;
            }

            // Calculate how many more B required to get k B's by k - freq[B] 
            // But first check if 'B' is in freq
            // Then make min the calculated value
            int min = 0;
            if (freq.ContainsKey('B'))
            {
                min = k - freq['B'];
            }
            else
            {
                min = k;
            }

            // Iterate over blocks with i = 0 and j = k
            int left = 0;
            for (int right = k; right < blocks.Length; right++)
            {
                // Deduce freq[blocks[i]] and increment freq[blokcs[j]]
                freq[blocks[left]] -= 1;
                freq[blocks[right]] = freq.GetValueOrDefault(blocks[right], 0) + 1;

                // Calculate value again and see if it's less than min
                if (freq.ContainsKey('B'))
                {
                    int diff = k - freq['B'];
                    if (diff < min)
                    {
                        min = diff;
                    }
                }

                left += 1;
            }

            // return min
            return min;
        }
    }
}
