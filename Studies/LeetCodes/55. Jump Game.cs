namespace Studies.LeetCodes;
public static class _55
{
    public static bool CanJump()
    {
        int[] nums = [2, 3, 1, 1, 4];
        
        int farthest = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > farthest)
                return false;
            farthest = Math.Max(farthest, i + nums[i]);
        }
        return true;
    }
}