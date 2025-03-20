namespace GraphGemini;

public class _695
{
    private int maxArea = 0;
    public int MaxAreaOfIsland(int[][] grid)
    {
        int rows = grid.Length;
        int columns = grid[0].Length;
        var visited = new int[rows,columns];
        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (grid[i][j] == 1 && visited[i, j] == 0)
                {
                    MaxAreaHelper(grid,visited, ref count, i, j);
                    maxArea = Math.Max(count, maxArea);
                    count = 0;
                }
            }
        }

        return maxArea;
    }

    private void MaxAreaHelper(int[][] grid, int[,] visited, ref int count, int row, int column)
    {
        if (row>=0 && column>=0 && row<grid.Length && column<grid[0].Length && visited[row,column] == 0 &&  grid[row][column]==1)
        {
            visited[row, column] = 1;
            count++;
            MaxAreaHelper(grid, visited, ref count, row-1, column);
            MaxAreaHelper(grid, visited, ref count, row, column-1);
            MaxAreaHelper(grid, visited, ref count, row+1, column);
            MaxAreaHelper(grid, visited, ref count, row, column+1);
        }
    }
}