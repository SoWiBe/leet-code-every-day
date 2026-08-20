
public class Solution {
    public IList<int> FindAnagrams(string s, string p) 
    {
        Dictionary<char, int> lessChars = [];
        List<int> indexes = [];

        var lessSize = 0;
        var biggerSize = 0;
        var workingStr = string.Empty;

        if (s.Length >= p.Length)
        {
            FillDict(p, lessChars);
            lessSize = p.Length;
            biggerSize = s.Length;
            workingStr = s;
        } 
        else
        {
            return [];
        }

        var left = 0;
        var right = lessSize - 1;
        
        while (right != biggerSize)
        {
            var checkingChars = new Dictionary<char, int>(lessChars);
            for (var i = left; i <= right; i++)
            {
                if (checkingChars.TryGetValue(workingStr[i], out var value)){
                    if (value > 0)
                    {
                        checkingChars[workingStr[i]]--;
                        if (i == right)
                        {
                            indexes.Add(left);
                        }
                    }
                    else break;
                }
                else break;
            }

            left++;
            right++;
        }

        return indexes;
    }

    private static void FillDict(string str, Dictionary<char, int> dict)
    {
        for (var i = 0; i < str.Length; i++)
        {
            if (dict.TryGetValue(str[i], out var value))
            {
                dict[str[i]]++;
            }
            else
            {
                dict[str[i]] = 1;
            }
        }
    }
}