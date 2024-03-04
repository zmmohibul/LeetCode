namespace BagOfTokens;

class Program
{
    static void Main(string[] args)
    {
        var tokens = new int[] { 100, 200, 300, 400 };
        var power = 200;
        
        var sl = new Solution();
        Console.WriteLine(sl.BagOfTokensScore(tokens, power));
    }
}