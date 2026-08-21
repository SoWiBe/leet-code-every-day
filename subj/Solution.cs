namespace LeetApp.subj;

public class Solution {
    
    // /// <summary>
    // /// First solution, but is not covered all cases, need to be optimized
    // /// </summary>
    // /// <param name="s"></param>
    // /// <param name="p"></param>
    // /// <returns></returns>
    // public static IList<int> FindAnagrams(string s, string p) 
    // {
    //     Dictionary<char, int> lessChars = [];
    //     List<int> indexes = [];
    //
    //     if (s.Length >= p.Length)
    //         FillDict(p, lessChars);
    //     else
    //         return [];
    //
    //     var left = 0;
    //     var right = p.Length - 1;
    //     
    //     while (right != s.Length)
    //     {
    //         var checkingChars = new Dictionary<char, int>(lessChars);
    //         for (var i = left; i <= right; i++)
    //         {
    //             if (checkingChars.TryGetValue(s[i], out var value)){
    //                 if (value > 0)
    //                 {
    //                     checkingChars[s[i]]--;
    //                     if (i == right)
    //                     {
    //                         indexes.Add(left);
    //                     }
    //                 }
    //                 else break;
    //             }
    //             else break;
    //         }
    //
    //         left++;
    //         right++;
    //     }
    //
    //     return indexes;
    // }

    /// <summary>
    /// Wanna be time complexity O(N + X), and space complexity O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="p"></param>
    /// <returns></returns>
    public static IList<int> FinaAnagramsByArray(string s, string p)
    {
        if (p.Length > s.Length) return [];
        List<int> indexes = [];

        Span<int> pFreq = stackalloc int[26];
        FillFreq(p, pFreq);
        
        Span<int> windowFreq = stackalloc int[26];
        
        for (var i = 0; i < s.Length; i++)
        {
            if (i >= p.Length) windowFreq[s[i - p.Length] - 'a']--;
            windowFreq[s[i] - 'a']++;
            
            if (windowFreq.SequenceEqual(pFreq)) indexes.Add(i - p.Length + 1);
        }
        
        return indexes;
    }

    private static void FillFreq(ReadOnlySpan<char> str, Span<int> freq)
    {
        foreach (var t in str) freq[t - 'a']++; // для каждого символа из алфавита заполняем его кол-во относительно подмассива
    }

    private static void ClearFreq(Span<int> freq)
    {
        freq.Clear();
    }
}