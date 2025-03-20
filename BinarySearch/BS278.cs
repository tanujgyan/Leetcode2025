namespace BinarySearch;

public class BS278
{
    public int FirstBadVersion(int n)
    {
        var low = 1;
        var high = n;
        var mid = -1;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (IsBadVersion(mid))
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }

    public bool IsBadVersion(int version)
    {
       if(version == 1702766719)
       {
           return true;
       }

       return false;
    }
}