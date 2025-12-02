namespace Studies.LeetCodes;
public static class _1590
{
    public static int MinSubarray()
    {
        int[] nums = [1000000000, 1000000000, 1000000000];
        int p = 3;

        long sum = 0;

        foreach (var num in nums)
        {
            sum += num;
        }

        int target = (int)(sum % p);
        if (target == 0) return 0;

        Dictionary<long, long> prefixModIndex = new Dictionary<long, long>();
        prefixModIndex[0] = -1;
        int currentMod = 0;
        int minLength = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            currentMod = (currentMod + nums[i]) % p;
            int neededMod = (currentMod - target + p) % p;
            if (prefixModIndex.ContainsKey(neededMod))
            {
                int subarrayLength = i - prefixModIndex[neededMod];
                if (subarrayLength < minLength)
                {
                    minLength = subarrayLength;
                }
            }
            prefixModIndex[currentMod] = i;
        }

        Console.WriteLine(minLength == nums.Length ? -1 : minLength);
        return minLength == nums.Length ? -1 : minLength;
        return 1;
    }
}