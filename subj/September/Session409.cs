namespace LeetApp.subj.September;

public static class Session409
{
    public static int FirstStableIndex(int[] nums, int k)
    {
        var max = nums[0];
        var min = nums[^1];

        var smallestIndex = -1;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max) max = nums[i];
            min = RecalcMin(nums[i..]);

            if (max - min <= k) return i;
        }

        return smallestIndex;
    }

    private static int RecalcMin(int[] minArr)
    {
        var min = minArr[0];
        foreach(var m in minArr){
            if (min > m) min = m;
        }

        return min;
    }
}