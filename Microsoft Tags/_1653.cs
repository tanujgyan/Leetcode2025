namespace Microsoft_Tags;

public class _1653
{
    public int MinimumDeletions(string s)
    {
        var minDeletion = s.Length;
        int[] rightCountA = new int[s.Length];
        int[] leftCountB = new int[s.Length];
        leftCountB[0] = 0;
        rightCountA[s.Length - 1] = 0;
        for(int i=1;i<s.Length;i++)
        {
            if (s[i - 1] == 'b')
            {
                leftCountB[i] = leftCountB[i - 1] + 1;
            }
            else
            {
                leftCountB[i] = leftCountB[i - 1];
            }
        }
        for(int i=s.Length-2;i>=0;i--)
        {
            if (s[i+1] == 'a')
            {
                rightCountA[i] = rightCountA[i + 1] + 1;
            }
            else
            {
                rightCountA[i] = rightCountA[i + 1];
            }
        }

        for (int i = 0; i < rightCountA.Length; i++)
        {
            minDeletion = Math.Min(rightCountA[i] + leftCountB[i], minDeletion);
        }

        return minDeletion;
    }
    
}