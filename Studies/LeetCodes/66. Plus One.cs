namespace Studies.LeetCodes;
public static class _66
{
    public static int[] PlusOne()
    {
        int[] digits = [9,9];
        int lastValue = digits[digits.Length - 1];

        List<int> list = new (digits);

        if (lastValue == 9)
        {
            if (digits[digits.Length - 1] == 9 && digits.Length == 1)
            {
                list[list.Count - 1] = 1;
                list.Add(0);
                return list.ToArray();
            }
            else
            {
                list[list.Count - 1] = 0;
                for (int i = list.Count - 2; i >= 0; i--)
                {
                    if (list[i] == 9)
                    {
                        list[i] = 0;
                    }
                    else
                    {
                        list[i] = list[i] + 1;
                        return list.ToArray();
                    }
                }
                list.Insert(0, 1);
                return list.ToArray();
            }
        }

        list[list.Count - 1] = lastValue + 1;

        return list.ToArray();
    }
}