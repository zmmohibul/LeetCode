namespace FruitIntoBaskets;

public class Solution
{
    public int TotalFruit(int[] fruits)
    {
        // [1,1,1,1,2,2,2,2,3,3,3,3,3,3,1]
        // [1,2,3,2,2]
        // [1,0,1,4,1,4,1,2,3]
        
        
        // var hs = new HashSet<int>();
        // var hsMax = new HashSet<int>();
        // var d = new Dictionary<int, int>();
        // var i = 0;
        // var j = 1;
        // hs.Add(fruits[i]);
        // hs.Add(fruits[j]);
        // for (j = 1; j < fruits.Length; j++)
        // {
        //     if (!hs.Contains(fruits[j]))
        //     {
        //         hsMax.Add(j - i);
        //         hs = new HashSet<int>();
        //         i = j - 1;
        //         hs.Add(fruits[i]);
        //         hs.Add(fruits[j]);
        //     }
        // }
        //
        // hsMax.Add(j - i);
        //
        // return hsMax.Max();

        var hsMax = new HashSet<int>();
        for (int i = 0; i < fruits.Length; i++)
        {
            var hs = new HashSet<int>();
            hs.Add(fruits[i]);
            var j = 0;
            for (j = i; j < fruits.Length; j++)
            {
                hs.Add(fruits[j]);
                if (hs.Count == 3)
                {
                    break;
                }
            }

            hsMax.Add(j - i);
        }

        return hsMax.Max();
    }
}