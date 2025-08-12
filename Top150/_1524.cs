namespace Top150;

public class _1524 {
    public int NumOfSubarrays(int[] arr)
    {
        var oddCount = 0;
        var evenCount = 0;
        var currentSum = 0;
        var result = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            
            currentSum += arr[i];
            if (currentSum % 2 == 0)
            {
                evenCount++;
                result += oddCount;
            }
            else
            {
                oddCount++;
                result += evenCount;
            }
        }

        return result;
    }
}