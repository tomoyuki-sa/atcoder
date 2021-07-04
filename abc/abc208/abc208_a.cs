// https://atcoder.jp/contests/abc208/submissions/23996374

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = input[0];
        var B = input[1];

        Console.WriteLine(A <= B && B <= 6 * A ? "Yes" : "No");
    }
}
