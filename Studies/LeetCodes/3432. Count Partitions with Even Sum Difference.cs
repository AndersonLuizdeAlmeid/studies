namespace Studies.LeetCodes;
public static class _3432
{
    public static int CountPartitions()
    {
        int[] nums = [2, 4, 6, 8];

        List<int> numberResting = nums.ToList();
        List<int> result = new();
        int counter = 0;

        for (int i = 0; i < numberResting.Count - 1;)
        {
            result.Add(numberResting[i]);
            numberResting.RemoveAt(i);

            var sum = numberResting.Sum();
            var sumResult = result.Sum();
            if (Math.Abs(sum - sumResult) % 2 == 0)
            {
                counter++;
            }
        }

        return counter;
    }
}