using System.Net;

namespace LeetCode;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(UserRole.User.ToString());

    }
}

public enum UserRole
{
    User,
    Admin,
    SuperAdmin
}


public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var hashSet = new HashSet<int>();
        foreach (var num in nums)
        {
            hashSet.Add(num);
        }

        for (int i = 0; i < hashSet.Count(); i++)
        {
            nums[i] = hashSet.ElementAt(i);
        }

        return hashSet.Count();
    }
}

