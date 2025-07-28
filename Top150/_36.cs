namespace Top150;

public class _36
{
    public bool IsValidSudoku(char[][] board)
    {
       
        for (int row = 0; row < 9; row++)
        {
            List<char> temp = new List<char>();
            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] != '.')
                {
                    temp.Add(board[row][i]);
                }
            }

            if (!IsUniqueArray(temp))
            {
                return false;
            }
        }
        for (int column = 0; column < 9; column++)
        {
            List<char> temp = new List<char>();
            for (int i = 0; i < 9; i++)
            {
                if (board[i][column] != '.')
                {
                    temp.Add(board[i][column]);
                }
            }

            if (!IsUniqueArray(temp))
            {
                return false;
            }
        }

        if (IsUniqueGrid(board, 0) && IsUniqueGrid(board,3) && IsUniqueGrid(board, 6))
        {
            return true;

        }
        return false;
    }

    private bool IsUniqueArray(List<char> arr)
    {
        HashSet<char> uniqueSet = [];
        foreach (var element in arr)
        {
            if (!uniqueSet.Add(element))
            {
                return false;
            }
        }

        return true;

    }

    private bool IsUniqueGrid(char[][] board, int startRow)
    {
        List<char> temp1 = new List<char>();
        List<char> temp2 = new List<char>();
        List<char> temp3 = new List<char>();
        
        for (int i = startRow; i < startRow+3; i++)
        {
           
            for (int j = 0; j < 3; j++)
            {
                if (board[i][j] != '.')
                {
                    temp1.Add(board[i][j]);
                }
            }
            for (int j = 3; j < 6; j++)
            {
                if (board[i][j] != '.')
                {
                    temp2.Add(board[i][j]);
                }
            }
            for (int j = 6; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    temp3.Add(board[i][j]);
                }
            }
        }

        if (!IsUniqueArray(temp1) || !IsUniqueArray(temp2) || !IsUniqueArray(temp3))
        {
            return false;
        }
        return true;
    }
    
}