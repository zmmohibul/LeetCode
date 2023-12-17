namespace DesignFoodRatingSystem;

class FoodRatings 
{
    Dictionary<string, PriorityQueue<Food, Food>> cuisineFoodQueue = new();
    Dictionary<string, string> foodCuisine = new();
    Dictionary<string, int> foodRating = new();

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) 
    {
        for (int i = 0; i < cuisines.Length; i++)
        {
            if (!cuisineFoodQueue.ContainsKey(cuisines[i]))
            {
                cuisineFoodQueue[cuisines[i]] = new PriorityQueue<Food, Food>();
            }

            var food = new Food(foods[i], ratings[i]);

            cuisineFoodQueue[cuisines[i]].Enqueue(food, food);
            foodCuisine[foods[i]] = cuisines[i];
            foodRating[foods[i]] = ratings[i];
        }
    }
    
    public void ChangeRating(string food, int newRating)
    {
        var f = new Food(food, newRating);
        cuisineFoodQueue[foodCuisine[food]].Enqueue(f, f);
        foodRating[food] = newRating;
    }
    
    public string HighestRated(string cuisine)
    {
        var foodQueue = cuisineFoodQueue[cuisine];

        var food = foodQueue.Dequeue();
        while (food.Rating != foodRating[food.Name])
        {
            food = foodQueue.Dequeue();
        }
        
        foodQueue.Enqueue(food, food);

        return food.Name;
    }
}

public class Food : IComparable<Food>
{
    public string Name { get; set; }

    public int Rating { get; set; }

    public Food(string name, int rating)
    {
        Name = name;
        Rating = rating;
    }

    public int CompareTo(Food? other)
    {
        if (Rating == other.Rating)
        {
            return Name.CompareTo(other.Name);
        }

        return other.Rating.CompareTo(Rating);
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */