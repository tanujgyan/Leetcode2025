namespace LeetCode;

public class MinDaysToMakeBouquets
{
    public int MinDays(int[] bloomDay, int m, int k)
    {
        var length = bloomDay.Length;
        var list = bloomDay.Distinct().OrderBy(x => x).ToList();
        int result = -1;

        var head = 0;
        var tail = list.Count-1;
        while (head <= tail)
        {
            var mid = (head + tail) / 2;
            if (CanMakeBouquet(list[mid], bloomDay, m, k))
            {
                result = list[mid];
                tail = mid-1;
            }
            else
            {
                head = mid+1;
            }
        }

        return result;
    }

    private bool CanMakeBouquet(int mid, int[] bloomDay, int m, int k)
    {
        for (var i = 0; i < bloomDay.Length; i++)
        {
            var flag = 0;
            if (i + k > bloomDay.Length && m > 0)
            {
                return false;
            }

            for (var j = i; j < i+k; j++)
            {
                if (bloomDay[j] > mid)
                {
                    flag = -1;
                    break;
                }
            }


            if (flag == 0)
            {
                i = i + k - 1;
                m--;
                if (m == 0)
                {
                    return true;
                }
            }
        }

        return false;
    }
}