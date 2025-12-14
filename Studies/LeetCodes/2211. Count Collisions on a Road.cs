namespace Studies.LeetCodes;
public static class _2211
{
    public static int CountCollisions()
    {
        string directions = "LLRR";
        int count = 0;
        var newDirs = directions.TrimStart('L').TrimEnd('R');
        foreach (var dir in newDirs)
        {
            if (dir != 'S')
            {
                count++;
            }
        }

        return count;
    }
}