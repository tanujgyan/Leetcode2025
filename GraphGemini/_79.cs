namespace GraphGemini;

public class _79
{
    private bool success = false;
    public bool Exist(char[][] board, string word)
    {
        int rows = board.Length;
        int columns = board[0].Length;
        bool[,] visited = new bool[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (board[i][j] == word[0])
                {
                    visited = new bool[rows, columns];
                    var success = ExistsHelper(board, word, visited, i, j, 0);
                    if (success)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    private bool ExistsHelper(char[][] board, string word, bool[,] visited, int row, int column, int wordIndex)
    {
        if (row<0 || column<0 || row>board.Length-1 || column>board[0].Length-1 || visited[row, column] || success)
        {
            return success;
        }
       
        
        if (board[row][column] == word[wordIndex])
        {
            visited[row, column] = true;
            if (wordIndex == word.Length - 1)
            {
                success = true;
                return success;
            }
            ExistsHelper(board,word,visited,row+1,column, wordIndex+1);
            ExistsHelper(board,word,visited,row,column+1, wordIndex+1);
            ExistsHelper(board,word,visited,row-1,column, wordIndex+1);
            ExistsHelper(board,word,visited,row,column-1, wordIndex+1);
        }

        visited[row, column] = false;
        return success;
    }
}