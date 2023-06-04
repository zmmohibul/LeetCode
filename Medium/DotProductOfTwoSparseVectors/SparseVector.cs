namespace DotProductOfTwoSparseVectors;

public class SparseVector 
{
    private Dictionary<int, int> ValueIndices { get; set; }
    public SparseVector(int[] nums)
    {
        ValueIndices = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                ValueIndices[i] = nums[i];
            }
        }
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec)
    {
        var v1 = vec.ValueIndices.Count < ValueIndices.Count ? vec.ValueIndices : ValueIndices;
        var v2 = ValueIndices.Count > vec.ValueIndices.Count ? ValueIndices : vec.ValueIndices;
        
        var product = 0;
        foreach (var (index, value) in v1)
        {
            if (v2.ContainsKey(index))
            {
                product += (value * v2[index]);
            }
        }

        return product;
    }
}
