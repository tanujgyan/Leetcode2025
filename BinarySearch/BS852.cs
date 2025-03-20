namespace BinarySearch;

public class BS852
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        var low = 1;
        var high = arr.Length - 2;
        var mid = -1;
        if (arr.Length == 3)
        {
            return 1;
        }
        while (low <= high)
        {
            mid = (low + high) / 2;
            if(arr[mid]>arr[mid-1] && arr[mid]>arr[mid+1])
            {
                return mid;
            }

            if (arr[mid - 1] <= arr[mid] &&
                arr[mid + 1] >= arr[mid])
            {
                low = mid + 1;
            }
            if (arr[mid - 1] >= arr[mid] &&
                arr[mid + 1] <= arr[mid])
            {
                high = mid - 1;
            }
        }

        return -1;
    }
}