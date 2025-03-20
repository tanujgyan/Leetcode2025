namespace BinarySearch;

public class BS658
{
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        if (x < arr[0])
        {
            return arr.Take(k).ToList();
        }

        if (x > arr[arr.Length - 1])
        {
            return arr.Skip(arr.Length - k).Take(k).ToList();
        }

        var low = 0;
        var high = arr.Length - 1;
        var mid = -1;
        var position = -1;
        var left =-1;
        var right = -1;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (arr[mid] == x)
            {
                left = mid;
                right = mid + 1;
                position = mid;
                break;
            }

            if (arr[mid] > x)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        if (position == -1)
        {
            if (low >= 1 && Math.Abs(arr[low] - x) >= Math.Abs(arr[low - 1] - x))
            {
                left = low - 1;
                right = low;
            }
            else
            {
                left = low;
                right = low + 1;
            }
        }

        var result = new List<int>();
       
            for (var i = 0; i < k; i++)
            {
                if (left < 0)
                {
                    result.Add(arr[right]);
                    right++;
                }

                else if (right > arr.Length - 1)
                {
                    result.Add(arr[left]);
                    left--;
                }
                else if(Math.Abs(arr[left]-x) <= Math.Abs(arr[right]-x))
                {
                    result.Add(arr[left]);
                    left--;
                }
                else
                {
                    result.Add(arr[right]);
                    right++;
                }

            }
            result.Sort();
            return result;
    }
}