namespace TimeBasedKeyValueStore;

public class TimeMap 
{
    private Dictionary<string, List<Tuple<int, string>>> timeKeyDictionary;

    public TimeMap() 
    {
        timeKeyDictionary = new Dictionary<string, List<Tuple<int, string>>>();
    }
    
    public void Set(string key, string value, int timestamp) 
    {
        if (!timeKeyDictionary.ContainsKey(key))
        {
            timeKeyDictionary[key] = new List<Tuple<int, string>>();
        }

        timeKeyDictionary[key].Add(new Tuple<int, string>(timestamp, value));
    }
    
    public string Get(string key, int timestamp) 
    {
        if (!timeKeyDictionary.ContainsKey(key))
        {
            return string.Empty;
        }

        var timeValueList = timeKeyDictionary[key];
        if (timeValueList.Count == 0 || timestamp < timeValueList[0].Item1)
        {
            return string.Empty;
        }

        var low = 0;
        var high = timeValueList.Count;
        while (low < high)
        {
            var mid = (high + low) / 2;

            if (timeValueList[mid].Item1 <= timestamp)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        if (high == 0)
        {
            return "";
        }

        return timeValueList[high - 1].Item2;
    }
}