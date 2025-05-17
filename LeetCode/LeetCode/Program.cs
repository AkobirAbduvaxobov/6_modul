namespace LeetCode;

public class Program
{
    static void Main(string[] args)
    {
        var s = new Solution();
        
        /// 10 9 9 9 9 8 7 6 5 4
    }
}

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        // [1,3,5,6, 10, 20, 90] 80

        if (nums[0] >= target) return 0;
        if (nums[nums.Count() - 1] < target) return nums.Count();

        for (var i = 1; i < nums.Count(); i++)
        {
            if (nums[i] >= target) return i;

        }

        return 0;
    }
}
