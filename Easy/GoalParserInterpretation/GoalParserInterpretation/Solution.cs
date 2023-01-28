using System.Text;

namespace GoalParserInterpretation;

public class Solution
{
    public string Interpret(string command)
    {
        var result = new StringBuilder();
        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == 'G')
            {
                result.Append('G');
            }
            else if (command[i] == '(' && command[i + 1] != ')')
            {
                result.Append("al");
                i += 3;
            }
            else
            {
                result.Append('o');
                i++;
            }
        }

        return result.ToString();
    }
}