namespace BestTimeToBuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(Solution.MaxProfit(prices));
        }
    }
}