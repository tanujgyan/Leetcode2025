namespace BinarySearch;

public class BS744
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        var low = 0;
        var high = letters.Length - 1;
        if (target.CompareTo(letters[low]) < 0 || target.CompareTo(letters[high]) >= 0)
        {
            return letters[low];
        }


        var result = BinarySearch(letters, target, low, high);
        while (true)
        {
            if (letters[result] != target)
            {
                return letters[result];
            }

            result = BinarySearch(letters, target, result+1, high);
        }

    }

    public int BinarySearch(char[] letters, char target, int low, int high)
    {
        int mid;
        
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (target.CompareTo(letters[mid]) > 0)
            {
                low = mid + 1;
            }
            else  if (target.CompareTo(letters[mid]) < 0)
            {
                high = mid - 1;
            }
            else
            {
                return mid+1;
            }
            
        }

        return low;
    }
}