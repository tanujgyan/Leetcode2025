namespace DBGemini;

public class _322
{
    public int CoinChange(int[] coins, int amount)
    {
        var arr = new int[amount + 1];
        arr[0] = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            var numberOfCoins = int.MaxValue;
            for (int j = 0; j < coins.Length; j++)
            {
                if (i - coins[j] >= 0 && arr[i-coins[j]]!=-1)
                {
                    numberOfCoins = Math.Min(numberOfCoins, arr[i-coins[j]] + 1);
                }
            }

            arr[i] = numberOfCoins == int.MaxValue ? -1 : numberOfCoins;
        }

        return arr[^1];
    }
}