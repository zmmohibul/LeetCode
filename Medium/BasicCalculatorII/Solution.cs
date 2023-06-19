using System.Text;

namespace BasicCalculatorII;

public class Solution
{
    public int Calculate(string s)
    {
        var validOperators = new HashSet<char>() { '+', '-', '*', '/' };
        var validNumbers = new HashSet<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        var operatorsStack = new LinkedList<char>();

        var numbersStack = new LinkedList<int>();
        
        var i = 0;
        while (i < s.Length)
        {
            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }
            
            if (i < s.Length && validNumbers.Contains(s[i]))
            {
                var n = 0;
                while (i < s.Length && validNumbers.Contains(s[i]))
                {
                    n *= 10;
                    n += (s[i] - '0');
                    i++;
                }
                numbersStack.AddLast(n);
            }

            if (i < s.Length && validOperators.Contains(s[i]))
            {
                if (numbersStack.Count > 1)
                {
                    var op = operatorsStack.Last.Value;
                    operatorsStack.RemoveLast();

                    var n2 = numbersStack.Last.Value;
                    numbersStack.RemoveLast();

                    var n1 = numbersStack.Last.Value;
                    numbersStack.RemoveLast();

                    if (op == '*')
                    {
                        numbersStack.AddLast(n1 * n2);
                    }
                    else if (op == '/')
                    {
                        numbersStack.AddLast(n1 / n2);
                    }
                    else
                    {
                        operatorsStack.AddLast(op);

                        numbersStack.AddLast(n1);
                        numbersStack.AddLast(n2);
                    }
                }
                operatorsStack.AddLast(s[i]);


                i++;
            }
            
            
        }
        
        if (numbersStack.Count > 1)
        {
            var op = operatorsStack.Last.Value;
            operatorsStack.RemoveLast();

            var n2 = numbersStack.Last.Value;
            numbersStack.RemoveLast();

            var n1 = numbersStack.Last.Value;
            numbersStack.RemoveLast();

            if (op == '*')
            {
                numbersStack.AddLast(n1 * n2);
            }
            else if (op == '/')
            {
                numbersStack.AddLast(n1 / n2);
            }
            else
            {
                operatorsStack.AddLast(op);

                numbersStack.AddLast(n1);
                numbersStack.AddLast(n2);
            }
        }

        while (operatorsStack.Count > 0)
        {
            var op = operatorsStack.First.Value;
            operatorsStack.RemoveFirst();

            var n1 = numbersStack.First.Value;
            numbersStack.RemoveFirst();

            var n2 = numbersStack.First.Value;
            numbersStack.RemoveFirst();

            if (op == '+')
            {
                numbersStack.AddFirst(n1 + n2);
            }
            else
            {
                numbersStack.AddFirst(n1 - n2);
            }
        }


        return numbersStack.First.Value;
    }
}