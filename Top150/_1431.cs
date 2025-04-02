namespace Top150;

public class _1431
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxCandies = 0;
        var result = new bool[candies.Length];
        foreach (var candy in candies)
        {
            maxCandies = Math.Max(candy, maxCandies);
        }

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= maxCandies)
            {
                result[i] = true;
            }
            else
            {
                result[i] = false;
            }
        }

        return result;
    }
}