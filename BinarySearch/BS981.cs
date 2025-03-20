namespace BinarySearch;

public class TimeMap
{
    private readonly Dictionary<string, TimeMapValues> _dictionary = new();

    public void Set(string key, string value, int timestamp)
    {
        if (_dictionary.ContainsKey(key))
        {
            _dictionary[key].Value.Add(value);
            _dictionary[key].TimeStamp.Add(timestamp);
        }
        else
        {
            _dictionary.Add(key, new TimeMapValues { Value = [value], TimeStamp = [timestamp] });
        }
    }

    public string Get(string key, int timestamp)
    {
        if(!_dictionary.ContainsKey(key))
        {
            return "";
        }
        var timestampList = _dictionary[key].TimeStamp;
        var low = 0;
        var high = _dictionary[key].TimeStamp.Count - 1;
        var mid = -1;
        if(timestamp>timestampList[^1])
        {
            return _dictionary[key].Value[^1];
        }
        if(timestamp<timestampList[0])
        {
            return "";
        }
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (timestampList[mid] < timestamp)
            {
                low = mid + 1;
            }
            else if (timestampList[mid] > timestamp)
            {
                high = mid - 1;
            }
            else
            {
                return _dictionary[key].Value[mid];
            }
        }
        return high < low ? _dictionary[key].Value[low] : "";
    }
}


public class TimeMapValues
{
    public List<string> Value = [];
    public List<int> TimeStamp = [];
}