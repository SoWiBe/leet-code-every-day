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
    
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var max = 0;

        while(left < right)
        {
            var s = (right - left) * (Math.Min(height[left], height[right]));
            max = Math.Max(max, s);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return max;
    }
    
    /// <summary>
    /// 167. Two Sum II - Input Array Is Sorted
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
                return [left + 1, right + 1];
            
            if (numbers[left] + numbers[right] < target) left++;
            else right--;
        }

        return [];
    }
}