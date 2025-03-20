namespace Top150;

public class _189
{
    public void Rotate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        var currentElementIndex = 0;
        var currentElementValue = nums[0];
        
        if (k > nums.Length)
        {
            k = k % nums.Length;
        }
        for (int i = 0; i < nums.Length;)
        {
            if (dict.TryAdd(currentElementIndex, currentElementValue))
            {
                i++;
            }
            else
            {
                currentElementIndex = currentElementIndex == nums.Length - 1 ? 0 : currentElementIndex+1;
                currentElementValue = nums[currentElementIndex];
                continue;
            }
            var newIndex = -1;
            if (currentElementIndex + k < nums.Length)
            {
                newIndex = currentElementIndex + k;
            }
            else
            {
                newIndex = currentElementIndex + k-nums.Length;
            }

           
            var temp = nums[newIndex];
            nums[newIndex] = currentElementValue;
            currentElementIndex = newIndex;
            currentElementValue = temp;
        }
    }
}