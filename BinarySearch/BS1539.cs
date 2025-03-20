namespace BinarySearch;

public class BS1539
{
    public int FindKthPositive(int[] arr, int k)
    {
        var low = 0;
        var high = arr.Length - 1;
        var mid = -1;
        var missing = -1;
        while (low <= high)
        {
            mid = (low + high) / 2;
            var expected = mid + 1;
            var actual = arr[mid];
            missing = actual - expected;
            if (missing >= k)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return low + k;
    }
}