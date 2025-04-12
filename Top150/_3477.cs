namespace Top150;

public class _3477
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var unplaced = 0;
        HashSet<int> dict = new HashSet<int>();
        int[] max = new int[2];
        int[] min = new int[2];
        var placed = false;
        //place the first fruit
       
            for (int j = 0; j < baskets.Length; j++)
            {
                if (fruits[0] <= baskets[j])
                {
                    dict.Add(j);
                    min[0] = fruits[0];
                    min[1] = j;
                    max[0] = fruits[0];
                    max[1] = j;
                    placed = true;
                    break;
                }
            }
        

        if (!placed)
        {
            unplaced++;
        }
        for (int i = 1; i < fruits.Length; i++)
        {
            placed = false;
            if (fruits[i] >= max[0])
            {
                for (int j = max[1]; j < baskets.Length; j++)
                {
                    if (fruits[i] <= baskets[j] && !dict.Contains(j))
                    {
                        dict.Add(j);
                        max[0] = fruits[i];
                        max[1] = j;
                        placed = true;
                        break;
                    }
                }
            }
            else if (fruits[i] < max[0] && fruits[i] > min[0])
            {
                for (int j = min[1]; j < baskets.Length; j++)
                {
                    if (fruits[i] <= baskets[j] && !dict.Contains(j))
                    {
                        dict.Add(j);
                        placed = true;
                        break;
                    }
                }
            }
            else if (fruits[i] <= min[0])
            {
                for (int j = 0; j < baskets.Length; j++)
                {
                    if (fruits[i] <= baskets[j] && !dict.Contains(j))
                    {
                        dict.Add(j);
                        min[0] = fruits[i];
                        min[1] = j;
                        placed = true;
                        break;
                    }
                }
            }

            if (!placed)
            {
                unplaced++;
            }
        }

        return unplaced;
    }
}