using System.Text.RegularExpressions;

namespace Studies.LeetCodes;
public static class _3606
{
    public static IList<string> ValidateCoupons()
    {
        string[] code = code = ["SAVE20", "", "PHARMA5", "SAVE@20"];
        string[] bussinesLine = ["restaurant", "grocery", "pharmacy", "restaurant"];
        bool[] isActive = [true, true, true, true];


        string regex = "^[a-zA-Z0-9_]+$";
        var businessOrder = new Dictionary<string, int>
        {
            { "electronics", 0 },
            { "grocery", 1 },
            { "pharmacy", 2 },
            { "restaurant", 3 }
        };
        List<Tuple<string, string>> validCoupons = new List<Tuple<string, string>>();

        for (int i = 0; i < code.Length; i++)
        { 
            if (!Regex.IsMatch(code[i], regex) || string.IsNullOrEmpty(code[i]))
                continue;

            if (!businessOrder.ContainsKey(bussinesLine[i]))
                continue;

            if (isActive[i])
                validCoupons.Add(Tuple.Create(code[i], bussinesLine[i]));
        }

        var sortedCoupons = validCoupons
            .OrderBy(x => businessOrder[x.Item2])  
            .ThenBy(x => x.Item1)                  
            .Select(x => x.Item1)                  
            .ToArray();

        return sortedCoupons;
    }
}