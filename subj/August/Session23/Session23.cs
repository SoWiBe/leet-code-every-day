namespace LeetApp.subj.August.Session23;

public class Session23
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 1) return 1;

        Span<int> lastSeen  = stackalloc int[128];
        lastSeen.Fill(-1);

        var left = 0;
        var max = 0;
        
        for (var i = 0; i < s.Length; i++)
        {
            if (lastSeen[s[i]] >= left) left = lastSeen[s[i]] + 1;
            lastSeen[s[i]] = i;
            max = Math.Max(max, i - left + 1);
        }
        
        return max;
    }
}