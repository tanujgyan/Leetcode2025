namespace Neetcode150;

public class _49
{
    // public IList<IList<string>> GroupAnagrams(string[] strs)
    // {
    //     var result = new List<IList<string>>();
    //     var dictList = new Dictionary<int, Dictionary<SortedDictionary<char, int>,int>>();
    //     
    //     int groupNumber = -1;
    //     foreach (var str in strs)
    //     {
    //         bool success = false;
    //         if (dictList.ContainsKey(str.Length))
    //         {
    //             var tempDict = new SortedDictionary<char, int>();
    //             foreach (var s in str)
    //             {
    //                 if (!tempDict.TryAdd(s, 1))
    //                 {
    //                     tempDict[s]++;
    //                 }
    //             }
    //             foreach (var dict in dictList[str.Length].Keys)
    //             {
    //                 if (dict.SequenceEqual(tempDict))
    //                 {
    //                     result[dictList[str.Length][dict]].Add(str);
    //                     success = true;
    //                     break;
    //                 }
    //             }
    //
    //             if (!success)
    //             {
    //                 groupNumber++;
    //                 dictList[str.Length].Add(tempDict,groupNumber);
    //                 result.Add(new List<string>());
    //                 result[groupNumber].Add(str);
    //             }
    //             
    //         }
    //         else
    //         {
    //             var tempDict = new SortedDictionary<char, int>();
    //             foreach (var s in str)
    //             {
    //                 if (!tempDict.TryAdd(s, 1))
    //                 {
    //                     tempDict[s]++;
    //                 }
    //             }
    //             var tempSDict = new Dictionary<SortedDictionary<char, int>, int>();
    //             tempSDict.Add(tempDict, ++groupNumber);
    //             dictList.Add(str.Length,tempSDict);
    //             result.Add(new List<string>());
    //             result[groupNumber].Add(str);
    //         }
    //     }
    //
    //     return result;
    // }
    
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result = new List<IList<string>>();
        var groupNumber = 0;
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (var str in strs)
        {
            var tempStr = new string(str.OrderBy(c => c).ToArray());
            if (dict.ContainsKey(tempStr))
            {
                
              result[dict[tempStr]].Add(str);
            }
            else
            {
                dict.Add(tempStr,groupNumber);
                result.Add(new List<string>());
                result[groupNumber].Add(str);
                groupNumber++;

            }
        }

        return result;
    }
}