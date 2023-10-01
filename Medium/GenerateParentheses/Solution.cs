namespace GenerateParentheses;

public class Solution 
{
    public IList<string> GenerateParenthesis(int n) 
    {
        return GenerateParenthesisHelper(n).ToList();
    }

    private HashSet<string> GenerateParenthesisHelper(int n)
    {
        if (n == 1)
        {
            return new HashSet<string>{"()"};
        }

        var rest = GenerateParenthesisHelper(n - 1);
        var result = new HashSet<string>();
        foreach (var item in rest)
        {
            for (int i = 0; i < item.Length; i++)
            {
                result.Add(item.Substring(0, i) + "()" + item.Substring(i));
            }
        }

        return result;
    }
}