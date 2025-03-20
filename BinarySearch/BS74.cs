namespace BinarySearch;

public class BS74
{
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        var row = matrix.Length;
        var col = matrix[0].Length;
        for (var i = 0; i < col; i++)
        {
            if (target >= matrix[0][i] &&
                target <= matrix[row - 1][i])
            {
               var low = 0;
                var high = row - 1;
                var mid = -1;
                while (low <= high)
                {
                    mid = (low + high) / 2;
                    if (matrix[mid][i] == target)
                    {
                        return true;
                    }
                    else if (matrix[mid][i] < target)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
           
        }

        return false;
    }
}