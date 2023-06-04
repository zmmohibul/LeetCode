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
        var product = 0;
        foreach (var (index, value) in vec.ValueIndices)
        {
            if (ValueIndices.ContainsKey(index))
            {
                product += (value * ValueIndices[index]);
            }
        }

        return product;
    }
}
