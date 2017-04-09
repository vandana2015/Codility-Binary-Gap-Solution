using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int N)
    {
        if (N == 0) return 0;
        var bin = Convert.ToString(N, 2);
        char[] arr = bin.ToCharArray();
        int count = 0;
        string result = String.Empty;
        foreach (char c in arr)
        {
            if (c == '0')
            {
                count += 1;
                continue;
            }
            if (c == '1')
            {
                result = result + "," + count;
                count = 0;
            }
        }
        result = result.Substring(1, result.Length - 1);
        int[] arrOfInt = result.Split(',').Select(str => int.Parse(str)).ToArray();
        //Console.Write(result);
        return arrOfInt.Max();
    }
}
