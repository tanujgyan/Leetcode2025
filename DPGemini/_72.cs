namespace DBGemini;

public class _72
{
    public int MinDistance(string word1, string word2)
    {
        var lcs = LongestCommonSubsequence(word1, word2);
        
    }
    private int LongestCommonSubsequence(string text1, string text2)
    {
        var rows = text1.Length + 1;
        var columns = text2.Length + 1;
        var dp = CreateAndFill2DMatrix(rows, columns);
        for (int i = 1; i < rows; i++)
        {
            for (int j = 1; j < columns; j++)
            {
                if (text1[i-1] == text2[j-1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        return dp[rows - 1, columns - 1];
    }

    private int[,] CreateAndFill2DMatrix(int rows, int columns)
    {
        int[,] dp = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                dp[i, j] = 0;
            }
        }

        return dp;
    }
}