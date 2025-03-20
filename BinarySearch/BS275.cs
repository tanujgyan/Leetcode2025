namespace BinarySearch;

public class BS275
{
    public int HIndex(int[] citations)
    {
        var low = 0;
        var high = citations.Length - 1;
        var mid = -1;
        var hindex = -1;
        while (low <= high)
        {
            mid = (low + high) / 2;
            var h = citations.Length - mid;
            if (h >= citations[mid])
            {
                h = citations[mid];
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
            if (h > hindex)
            {
                hindex = h;
            }

            
        }

        return hindex;
    }
}