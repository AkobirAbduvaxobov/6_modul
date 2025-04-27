namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        var obj = new Solution();
        string s = "ABC";

        Console.WriteLine(obj.Convert(s, 4));

        /// PAHNAPLSIIGYIR  
        /// PAHNAPLSIIGYIR
        /// PINALSIGYAHRPI
        /// PINALSIGYAHRPI

    }
}


public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;

        var res = string.Empty;

        var lists = GetSmth(s, numRows);

        foreach (var list in lists)
        {
            foreach (var ch in list)
            {
                res += ch;
            }
        }

        return res;
    }

    private List<List<char>> GetSmth(string s, int n)
    {
        /// PAYPALISHIRING
        var lists = new List<List<char>>(); 
        for (var i = 0; i < n; i++)
        {
            lists.Add(new List<char>());
        }

        var helper = 0;
        var status = true;
        /// PAYPALISHIRING, 3
        // 1. P A 
        // 2. A P L
        // 3. Y 

        for (var i = 0; i < s.Length; i++) // i = 5
        {
            if(status == true)
            {
                lists[helper].Add(s[i]);
                helper++;

                if(helper == n)
                {
                    status = false;
                    helper--;
                }
            }

            else if(status == false)
            {
                helper--;
                lists[helper].Add(s[i]);

                if(helper == 0)
                {
                    status = true;
                    helper++;
                }
            }
        }

        return lists;
    }
}
