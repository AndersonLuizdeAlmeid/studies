namespace Studies.LeetCodes;
public static class _13
{
    public static int RomanToInt()
    {
        string s = "MCMXCIV";
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var countAux = GetValue(s[i]);

            if (i + 1 < s.Length)
            {
                var nextValue = GetValue(s[i + 1]);
                if (nextValue > countAux)
                {
                    count += nextValue - countAux;
                    i++;
                }
                else
                {
                    count += countAux;
                }
            }
            else
            {
                count += countAux;

            }
        }
        return count;
    }

    private static int GetValue(char ch)
    {
        return ch switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }
}