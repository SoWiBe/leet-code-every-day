namespace LeetApp.subj.August.Session22;

/// <summary>
/// 567. Permutation in String
/// </summary>
public class Session22 
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        Span<int> s1Freq = stackalloc int[26];
        Span<int> windowFreq = stackalloc int[26];
        
        FillFreq(s1, s1Freq);
        
        for (var i = 0; i < s2.Length; i++)
        {
            if (i >= s1.Length) windowFreq[s2[i - s1.Length] - 'a']--;
            windowFreq[s2[i] - 'a']++;

            if (windowFreq.SequenceEqual(s1Freq)) return true;
        }

        return false;
    }

    private static void FillFreq(ReadOnlySpan<char> str, Span<int> freq)
    {
        foreach (var t in str) freq[t - 'a']++;
    }
}