using System.Text;

namespace Top150;

public class Top150_6
{
    public string Convert(string s, int numRows)
    {
        var numberOfElements = s.Length;
        var numberOfElementsInAPattern = numRows + numRows - 2;
        if (numberOfElementsInAPattern == 0)
        {
            return s;
        }
        var numberOfPatterns = numberOfElements % numberOfElementsInAPattern == 0 ? numberOfElements / numberOfElementsInAPattern : (numberOfElements / numberOfElementsInAPattern) + 1;
        var matrix = new string[numRows][];
        for (int i = 0; i < numRows; i++)
        {
            matrix[i] = new string[numberOfPatterns * 2];
            for (int j = 0; j < numberOfPatterns * 2; j++)
            {
                matrix[i][j] = "@";
            }
        }

        for (int i = 0, j=0; i < numberOfElements; i =i+numberOfElementsInAPattern, j=j+2)
        {
            FillMatrix(matrix, s.Substring(i).Length >=numberOfElementsInAPattern ?
                s.Substring(i,numberOfElementsInAPattern) : s.Substring(i), j, numRows);
        }

        StringBuilder sb = new StringBuilder();
        for(int i=0;i<numRows;i++)
        {
            for (int j = 0; j < numberOfPatterns * 2; j++)
            {
                if (matrix[i][j] != "@")
                {
                    sb.Append(matrix[i][j]);
                }
            }
        }

        return sb.ToString();
    }

    private void FillMatrix(string[][] matrix, string substring, int startColumn, int numRows)
    {
            //fill first column
            for (int j = 0; j < numRows; j++)
            {
                if (j >= substring.Length)
                {
                    return;
                }
                matrix[j][startColumn] = substring[j].ToString();
            }
           
            if (substring.Substring(numRows).Length == 0)
            {
                return;
            }

            substring = new string(substring.Substring(numRows));
            int row = numRows-2;
            for (int j = 0; j < substring.Length; j++)
            {
                matrix[row][startColumn + 1] = substring[j].ToString();
                row--;
            }
    }
}