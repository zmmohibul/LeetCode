namespace MaximumValueOfStringInArray;

public class Solution {
    public int MaximumValue(string[] strs) {
        var numHs = new HashSet<char>{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        var max = 0;
        for (int i = 0; i < strs.Length; i++) 
        {
            var item = strs[i];
            var currVal = 0;
            var currNum = 0;
            for (int j = 0; j < item.Length; j++) 
            {
                if (numHs.Contains(item[j]))
                {
                    currNum *= 10;
                    currNum += (item[j] - '0');
                }
                else
                {
                    currVal = item.Length;
                    break;
                }
            }

            if (currVal > 0)
            {
                if (currVal > max)
                {
                    max = currVal;
                }
            }
            else
            {
                if (currNum > max)
                {
                    max = currNum;
                }
            }
        }

        return max;
    }
}