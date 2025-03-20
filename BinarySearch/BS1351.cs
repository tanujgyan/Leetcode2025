namespace BinarySearch;

public class BS1351
{
    public int CountNegatives(int[][] grid)
    {

        int rowLength = grid.Length;
        int columnLength = grid[0].Length;
        int length = rowLength * columnLength;
        //whole grid is negative
        if (grid[0][0] < 0)
        {
            return length;
        }
        //whole grid is positive
        if (grid[rowLength - 1][columnLength - 1] >= 0)
        {
            return 0;
        }

        int count = 0;
        for (int k = 0; k < rowLength; k++)
        {
            int[] arr = grid[k];
    
           
                int flag = 0;
                //if first elenment is negative then rest all will be negative
                if (arr[0] < 0)
                {
                    return count + ((rowLength - k) * columnLength);
                } 
                //if last element is positive then ignore that row
                if (arr[columnLength-1] >= 0)
                {
                    continue;
                }

                int low = 0;
                int high = columnLength - 1;
                int mid = -1;

                while (low <= high)
                {
                    mid = (low + high) / 2;
                    if (arr[mid] > -1)
                    {
                        low = mid + 1;
                    }
                    else if (arr[mid] < -1)
                    {
                        if (arr[mid - 1] >= 0)
                        {
                            count += columnLength - mid;
                            break;
                        }

                        high = mid - 1;
                    }
                }
        }

        return count;
    }
}