namespace BuyTwoChocolates;

public class Solution {
    public int BuyChoco(int[] prices, int money) {
        var minPrice = int.MaxValue;
        var secondMinPrice = int.MaxValue - 1;

        foreach (var price in prices)
        {
            if (price < minPrice)
            {
                secondMinPrice = minPrice;
                minPrice = price;
            }
            else if (price < secondMinPrice)
            {
                secondMinPrice = price;
            }
        }
        
        var sum = minPrice + secondMinPrice;

        if (sum > money)
        {
            return money;
        }

        return money - sum;
    }
}