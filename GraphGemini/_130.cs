namespace GraphGemini;

public class _130
{
    Stack<int[]> stack = new();
    
    public void Solve(char[][] board)
    {
        int rows = board.Length;
        int columns = board[0].Length;
        if (rows == 1 || columns ==1)
        {
            return;
        }
        var visited = new int[rows, columns];
        var success = false;
        for (int i = 1; i < rows - 1; i++)
        {
            for (int j = 1; j < columns - 1; j++)
            {
                if (board[i][j] == 'O' && visited[i,j]==0)
                {
                    success = false;
                    SolveHelper(board, visited,i,j,ref success);
                    if (!success)
                    {
                        while (stack.Count > 0)
                        {
                            var vertex = stack.Pop();
                            board[vertex[0]][vertex[1]] = 'X';
                        }
                    }
                    else
                    {
                        stack = new();
                    }
                }
            }
        }
    }

    private void SolveHelper(char[][] board, int[,] visited, int row, int column, ref bool success)
    {
        if (board[row][column] == 'X' || visited[row,column] ==1)
        {
            return;
        }
        if (row == 0 || column == 0 || row == board.Length - 1 || column == board[0].Length - 1)
        {
            success = true;
            return;
        }
        visited[row, column] = 1;
        stack.Push([row,column]);
        SolveHelper(board, visited, row-1, column, ref success);
        SolveHelper(board, visited, row, column-1, ref success);

        SolveHelper(board, visited, row+1, column, ref success);

        SolveHelper(board, visited, row, column+1, ref success);

    }
}




