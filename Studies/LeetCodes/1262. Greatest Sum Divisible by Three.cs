namespace Studies.LeetCodes;
public static class _1262
{
    public static int MaxSumDivThree()
    {
        int[] nums = [3, 6, 5, 1, 8];
        int totalSum = nums.Sum();
        int resto = totalSum % 3;

        if (resto == 0)
        {
            return totalSum;
        }

        List<int> uns = new List<int>();
        List<int> dois = new List<int>();

        foreach (int n in nums)
        {
            if (n % 3 == 1) uns.Add(n);
            else if (n % 3 == 2) dois.Add(n);
        }

        uns.Sort();
        dois.Sort();

        int maxSum = 0;

        if (resto == 1)
        {
            if (uns.Count >= 1)
            {
                maxSum = Math.Max(maxSum, totalSum - uns[0]);
            }
            if (dois.Count >= 2)
            {
                maxSum = Math.Max(maxSum, totalSum - dois[0] - dois[1]);
            }
        }
        else if (resto == 2)
        {
            if (dois.Count >= 1)
            {
                maxSum = Math.Max(maxSum, totalSum - dois[0]);
            }
            if (uns.Count >= 2)
            {
                maxSum = Math.Max(maxSum, totalSum - uns[0] - uns[1]);
            }
        }

        return maxSum;
    }
}
