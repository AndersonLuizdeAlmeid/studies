namespace Studies.LeetCodes;
public static class _3583
{
    public static int SpecialTriplets()
    {
        int[] nums = [0, 1, 0, 0];

        int n = nums.Length;
        int count = 0;
        int MOD = 1000000007;

        int[] leftCount = new int[n];
        int[] rightCount = new int[n];

        Dictionary<int, int> rightMap = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            if (rightMap.ContainsKey(nums[i]))
                rightMap[nums[i]]++;
            else
                rightMap[nums[i]] = 1;
        }


        Dictionary<int, int> leftMap = new Dictionary<int, int>();

        for (int j = 1; j < n - 1; j++)
        {
            if (leftMap.ContainsKey(nums[j - 1]))
                leftMap[nums[j - 1]]++;
            else
                leftMap[nums[j - 1]] = 1;

            if (rightMap.ContainsKey(nums[j + 1]))
            {
                rightMap[nums[j + 1]]--;
                if (rightMap[nums[j + 1]] == 0)
                    rightMap.Remove(nums[j + 1]);
            }

            int target = nums[j] * 2;

            if (leftMap.ContainsKey(target) && rightMap.ContainsKey(target))
            {
                count += leftMap[target] * rightMap[target];
                count %= MOD;
            }

        }

        return count;
    }
}