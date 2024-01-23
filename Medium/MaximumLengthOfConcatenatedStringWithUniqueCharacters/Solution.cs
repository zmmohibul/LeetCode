namespace MaximumLengthOfConcatenatedStringWithUniqueCharacters;

public class Solution {
    int maxLength = 0;
    HashSet<string> cache = new();
    public int MaxLength(IList<string> arr) {
        FindMaxLength(arr, new HashSet<char>(), "", 0);
        return maxLength;
    }

    public void FindMaxLength(IList<string> arr, HashSet<char> uniqueStrSet, string str, int i)
    {
        maxLength = Math.Max(maxLength, str.Length);
        if (cache.Contains($"{str}-{i}") || (i == arr.Count)) {
            return;
        } 

        var currStr = arr[i];
        bool canConcatenate = true, currStrUnique = true;
        HashSet<char> currStrSet = new (), uniqueStrSetTemp = new(uniqueStrSet);
        foreach (var c in currStr) {
            if (currStrSet.Contains(c)) {
                currStrUnique = false;
            }

            if (uniqueStrSetTemp.Contains(c)) {
                canConcatenate = false;
            }

            currStrSet.Add(c);
            uniqueStrSetTemp.Add(c);
        }
        
        if (currStrUnique) {
            FindMaxLength(arr, currStrSet, currStr, i + 1);
            cache.Add($"{currStr}-{i}");
        }
        
        if (canConcatenate) {
            FindMaxLength(arr, uniqueStrSetTemp, str + currStr, i + 1);
            cache.Add($"{str + currStr}-{i}");
        }

        if (!currStrUnique || !canConcatenate || (currStrUnique && canConcatenate)) {
            FindMaxLength(arr, uniqueStrSet, str, i + 1);
            cache.Add($"{str}-{i}");
        }
    }
}