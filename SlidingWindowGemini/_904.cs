namespace SlidingWindowGemini;

public class _904 {
    public int TotalFruit(int[] fruits) {
        var firstValue = fruits[0];
        var secondValue = -1;
        var nextWindowStart = 0;
        var currentWindowStart = 0;
        var currentMaxWindowSize = 0;
        var nextWindowStartValue = fruits[0];
        for (int i = 1; i < fruits.Length; i++)
        {
            if (firstValue != fruits[i] && secondValue == -1)
            {
                secondValue = fruits[i];
                nextWindowStart = i;
                nextWindowStartValue = secondValue;
            }
            else if (fruits[i] == firstValue && secondValue!=-1 && nextWindowStartValue == secondValue)
            {
                nextWindowStart = i;
                nextWindowStartValue = firstValue;
            }
            else if (fruits[i] == firstValue && fruits[nextWindowStart] !=firstValue)
            {
                nextWindowStart = i;
            }
            else if (fruits[i] == secondValue && fruits[nextWindowStart] !=secondValue)
            {
                nextWindowStart = i;
            }
            else if (fruits[i] != firstValue && fruits[i] != secondValue)
            {
                currentMaxWindowSize = Math.Max(currentMaxWindowSize, i - currentWindowStart);
                currentWindowStart = nextWindowStart;
                firstValue = fruits[currentWindowStart];
                secondValue = fruits[i];
                nextWindowStartValue = secondValue;
                nextWindowStart=i;
            }
        }

        return Math.Max(currentMaxWindowSize, fruits.Length - currentWindowStart);
    }
}