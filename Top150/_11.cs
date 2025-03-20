namespace Top150;

public class _11
{
    public int MaxArea(int[] height) 
    {
       int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;
        int width = height.Length - 1;
        while (left < right)
        {
            var currentHeight = Math.Min(height[left], height[right]);
            var currentArea = currentHeight * width;
            maxArea = Math.Max(maxArea, currentArea);
            var leftHeight = CalculateHeight(height[left + 1], height[right]);
            var currentLeftHeight = Math.Max(leftHeight, currentHeight);
            var rightHeight = CalculateHeight(height[left], height[right - 1]);
            var currentRightHeight = Math.Max(rightHeight, currentHeight);
            if (currentLeftHeight > currentRightHeight)
            {
                left++;
            }
            else
            {
                right--;
            }
            width--;
        }

        return maxArea;

    }
    private int CalculateHeight(int height1, int height2)
    {
        return Math.Min(height1, height2);
    }
}