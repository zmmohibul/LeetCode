namespace CompareVersionNumbers;

public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        var revisionsInVersion1 = BuildRevisionListFromVersion(version1);
        var revisionsInVersion2 = BuildRevisionListFromVersion(version2);

        var smallerVersion = revisionsInVersion1.Count < revisionsInVersion2.Count
            ? revisionsInVersion1
            : revisionsInVersion2;
        
        var largerVersionCount = revisionsInVersion1.Count > revisionsInVersion2.Count
            ? revisionsInVersion1.Count
            : revisionsInVersion2.Count;

        for (int i = smallerVersion.Count; i < largerVersionCount; i++)
        {
            smallerVersion.Add(0);
        }

        for (int i = 0; i < revisionsInVersion1.Count; i++)
        {
            if (revisionsInVersion1[i] < revisionsInVersion2[i])
            {
                return -1;
            }
            else if (revisionsInVersion1[i] > revisionsInVersion2[i])
            {
                return 1;
            }
        }

        return 0;
    }

    public List<int> BuildRevisionListFromVersion(string version)
    {
        var revisionsInVersion = new List<int>();
        var i = 0;
        while (i < version.Length)
        {
            var n = 0;
            while (i < version.Length && version[i] != '.')
            {
                n *= 10;
                n += (version[i] - '0');
                
                i++;
            }
            
            revisionsInVersion.Add(n);

            i++;
        }

        return revisionsInVersion;
    }
}