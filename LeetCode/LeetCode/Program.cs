namespace LeetCode;

public class Program
{
    static void Main(string[] args)
    {
        var s = new Solution();
        var nums = new int[] { 8, 9, 9, 4, 10, 5, 6, 9, 7, 9 };
        /// 10 9 9 9 9 8 7 6 5 4
    }
}


public class Solution
{

    public int Rob(int[] nums)
    {
        if (nums.Count() == 1) return nums[0];
        if (nums.Count() == 2) return Math.Max(nums[0], nums[1]);



        var dictionary = new Dictionary<int, int>();
        for (var i = 0; i < nums.Count(); i++)
        {
            dictionary.Add(i, nums[i]);
        }

        

        dictionary = dictionary.OrderByDescending(i => i.Value).ToDictionary();

        var rrr = dictionary;

        var res = Do(dictionary);
        for (var i = 0; i < 2; i++)
        {
            dictionary.Remove(dictionary.First().Key);
            if(res < Do(dictionary))
            {
                res = Do(dictionary);
            }
        }



        return res;
    }

    public int Do(Dictionary<int, int> dictionary)
    {
        var summa = dictionary.First().Value;
        var indexes = new List<int>();
        indexes.Add(dictionary.First().Key);

        foreach (var item in dictionary)
        {
            var index = item.Key;
            var check = true;
            foreach (var i in indexes)
            {
                if(Math.Abs(index - i) <= 1)
                {
                    check = false;
                    break;
                }
            }

            if(check == true)
            {
                summa = summa + item.Value;
                indexes.Add(index);
            }
        }

        return summa;
    }
}