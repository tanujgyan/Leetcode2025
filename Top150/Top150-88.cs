namespace Top150;

public class Top150_88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        var pointer1 = m - 1;
        var pointer2 = n - 1;
        var insertPointer = m + n - 1;
        if (pointer1 < 0 && pointer2 >= 0)
        {
            for(int i=0;i<nums2.Length;i++)
            {
                nums1[i] = nums2[i];
            }

            return;
        }
        while (pointer2 >= 0)
        {
            if (pointer1 >=0 && nums1[pointer1] > nums2[pointer2])
            {
                nums1[insertPointer] =
                    nums1[pointer1];
                pointer1--;
                insertPointer--;
            }
            else
            {
                nums1[insertPointer] =
                    nums2[pointer2];
                pointer2--;
                insertPointer--;
            }
        }
    }

}