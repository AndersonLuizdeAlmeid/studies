namespace Studies.LeetCodes;
public static class _3
{
    public static int LengthOfLongestSubstring()
    {
        string str = "anviaj";
        int index = 0;
        int max = 0;
        int maxAux = 0;
        Dictionary<int, string> map = new Dictionary<int, string>();

        foreach (char cha in str)
        {
            if (map.Count == 0)
            {
                map.Add(index, cha.ToString());
                index++;
                maxAux++;
                max++;
                continue;
            }

            if (map[index - 1].Contains(cha))
            {
                index++;

                map.Add(index - 1, "");
                if (map[index - 2].Last() != cha) 
                { 
                    maxAux = 2; 
                    map[index - 1] = string.Concat(map[index - 2].Last(), cha); 
                }
                else 
                { 
                    maxAux = 1; 
                    map[index - 1] = cha.ToString(); 
                }
                continue;
            }
            else
                map[index - 1] = string.Concat(map[index - 1], cha);
            maxAux++;
            if (maxAux < map[index - 1].Length)
                max = map[index - 1].Length;
            if (maxAux > max)
                max = maxAux;
        }
        return max;
    }
}