namespace FindSmallestCommonElementInAllRows;

public class Solution 
{
    public int SmallestCommonElement(int[][] mat)
    {
        var firstRow = mat[0];
        for (int i = 0; i < firstRow.Length; i++)
        {
            var element = firstRow[i];
            var common = true;
            for (int j = 0; j < mat.Length; j++)
            {
                if (!BinarySearch(mat[j], element))
                {
                    common = false;
                    break;
                }
            }

            if (common)
            {
                return element;
            }
        }

        return -1;
    }

    public bool BinarySearch(int[] arr, int target)
    {
        var left = 0;
        var right = arr.Length - 1;
        
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                return true;
            }
            
            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
        
    }
}