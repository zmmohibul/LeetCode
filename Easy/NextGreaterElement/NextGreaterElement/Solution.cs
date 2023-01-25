namespace NextGreaterElement;

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var indexMapNums2 = new Dictionary<int, int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            indexMapNums2[nums2[i]] = i;
        }

        var result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            var next = -1;
            for (int j = indexMapNums2[nums1[i]]; j < nums2.Length; j++)
            {
                if (nums2[j] > nums1[i])
                {
                    next = nums2[j];
                    break;
                }
            }

            result[i] = next;
        }

        return result;
    }
}