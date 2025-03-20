namespace BinarySearch;

public class BS436
{
    public int[] FindRightInterval(int[][] intervals) 
    {
       var dictionary = new Dictionary<int, int>();
       List<int> sortedStarts = [];
       CreateDictionaryAndSortedList(dictionary, intervals, sortedStarts);
       var results = new int[intervals.Length];
       for (var i = 0; i < intervals.Length; i++)
       {
           var target = intervals[i][1];
           var low = 0;
           var high =sortedStarts.Count - 1;
           var mid = -1;
           while (low <= high)
           {
               mid = (low + high) / 2;
               if(target>sortedStarts[^1])
               {
                   results[i] = -1;
                   break;
               }

               if (target > sortedStarts[mid])
               {
                   low = mid + 1;
               }
               else if (target < sortedStarts[mid])
               {
                   high = mid - 1;
               }
               else
               {
                   results[i] = dictionary[sortedStarts[mid]];
                   break;
               }
           }

           if (high < low)
           {
               results[i] = dictionary[sortedStarts[low]];
           }
       }
       return results;
    }

    private void CreateDictionaryAndSortedList(Dictionary<int, int> dictionary, int[][] intervals, List<int> sortedStarts)
    {
        for(var i= 0;i<intervals.Length;i++)
        {
           dictionary.Add(intervals[i][0], i);
           sortedStarts.Add(intervals[i][0]);
        }
        sortedStarts.Sort();
    }
}