using System.Text;

namespace AddStrings;

public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        string rnum1 = num1;
        int in1 = num1.Length - 1;

        string rnum2 = num2;
        int in2 = num2.Length - 1;
        
        if (num1.Length < num2.Length)
        {
            rnum1 = num2;
            in1 = num2.Length - 1;
            
            rnum2 = num1;
            in2 = num1.Length - 1;
        }

        int n = Math.Min(in1, in2);
        int carry = 0;
        var result = new StringBuilder();
        for (int i = 0; i <= n; i++)
        {
            int n1 = num1[in1] - 48;
            in1 -= 1;
            
            int n2 = num2[in2] - 48;
            in2 -= 1;

            int sum = n1 + n2 + carry;
            carry = sum / 10;

            result.Insert(0, (sum % 10));
        }

        if (in1 >= 0)
        {
            while (in1 >= 0)
            {
                int n1 = num1[in1] - 48;
                in1 -= 1;
                
                int sum = n1 + carry;
                carry = sum / 10;
                
                result.Insert(0, (sum % 10));
            }
        }

        if (carry > 0)
        {
            result.Insert(0, carry);
        }

        return result.ToString();

    }
}