namespace BinarySearch;

public class BS374 {
    public int GuessNumber(int n) {
        
        
        //create and fill array
        var arr = new int[n];
        for (var i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        long low = 0;
        long high = n-1;
        long mid = -1;
        try
        {
            while (low <= high)
            {
                mid = (low+high)/2;
                int result = guess((int)mid + 1);
                if (result == 0)
                {
                    return (int)mid + 1;
                }
                else if (result == -1)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       
        return -1;
    }

    public int guess(int num)
    {
        if (num == 1702766719)
        {
            return 0;
        }
        else if (num < 1702766719)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}