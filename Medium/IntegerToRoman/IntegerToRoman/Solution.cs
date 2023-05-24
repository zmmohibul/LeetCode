using System.Text;

namespace IntegerToRoman;

public class Solution 
{
    public string IntToRoman(int num) 
    {
        var onesDict = new Dictionary<int, string>()
        {
            {1, "I"},
            {2, "II"},
            {3, "III"},
            {4, "IV"},
            {5, "V"},
            {6, "VI"},
            {7, "VII"},
            {8, "VIII"},
            {9, "IX"},
            {0, ""},
        };

        var tensDict = new Dictionary<int, string>()
        {
            {1, "X"},
            {2, "XX"},
            {3, "XXX"},
            {4, "XL"},
            {5, "L"},
            {6, "LX"},
            {7, "LXX"},
            {8, "LXXX"},
            {9, "XC"},
            {0, ""},
        };

        var hundredsDict = new Dictionary<int, string>()
        {
            {1, "C"},
            {2, "CC"},
            {3, "CCC"},
            {4, "CD"},
            {5, "D"},
            {6, "DC"},
            {7, "DCC"},
            {8, "DCCC"},
            {9, "CM"},
            {0, ""},
        };

        var thousandsDict = new Dictionary<int, string>()
        {
            {1, "M"},
            {2, "MM"},
            {3, "MMM"},
        };

        var dictList = new List<Dictionary<int, string>>() { onesDict, tensDict, hundredsDict, thousandsDict };

        var sb = new StringBuilder();
        var i = 0;
        while (num > 0)
        {
            sb.Insert(0, dictList[i][num % 10]);
            num /= 10;
            i++;
        }

        return sb.ToString();
    }
}