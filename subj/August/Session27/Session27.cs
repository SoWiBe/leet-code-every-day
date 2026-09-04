namespace LeetApp.subj.August.Session27;

public class Session27
{
    public string ShortestBeautifulSubstring(string s, int k)
    {
        var right = 0;
        var left = 0;
        var counter = 0;
        var candidate = s;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[right] == '1') right++;
            if (counter == k || s[left] == '0')
            {
                left++;
            }

            if (counter == k)
            {
                var sub = s[left..right];
                if (sub.Length < candidate.Length)
                {
                    candidate = sub;
                }
            }
        }

        return candidate;
    }
}