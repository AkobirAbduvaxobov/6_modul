namespace LeetCode;

public class Program
{
    static void Main(string[] args)
    {
       


    }
}

public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        IList<IList<int>> result = new List<IList<int>>();
        int position = 0;
        int[] current = new int[k];
        while (0 <= position)
        {
            current[position]++;
            if (n < current[position])
            {
                position--;
            }
            else if (position == k - 1)
            {
                result.Add(current.ToArray());
            }
            else
            {
                current[++position] = current[position - 1];
            }
        }
        return result;
    }
}