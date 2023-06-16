namespace TimeBasedKeyValueStore;

public class TimeMap 
{
    private Dictionary<string, SortedDictionary<int, string>> map;

    public TimeMap() 
    {
        map = new Dictionary<string, SortedDictionary<int, string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!map.ContainsKey(key))
        {
            map[key] = new SortedDictionary<int, string>();
        }

        map[key][timestamp] = value;
    }
    
    public string Get(string key, int timestamp) {
        if (!map.ContainsKey(key))
        {
            return "";
        }

        var d = map[key];
        if (d.Count == 0)
        {
            return "";
        }
        var k = -1;
        foreach (var (ky, value) in d)
        {
            if (timestamp >= ky)
            {
                k = ky;
            }
            else
            {
                break;
            }
        }

        if (k < 0)
        {
            return "";
        }

        return d[k];
    }
}