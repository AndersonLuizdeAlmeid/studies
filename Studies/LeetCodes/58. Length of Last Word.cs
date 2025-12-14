namespace Studies.LeetCodes;
public static class _58
{
    public static int LengthOfLastWord()
    {
        string s = "   fly me   to   the moon  ";
        int count = 0;
        var a = s.Trim();
        for(int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] == ' ')
                break;
            count++;
        }

        return count;
    }
}