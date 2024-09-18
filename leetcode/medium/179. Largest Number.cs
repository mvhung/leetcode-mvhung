using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.medium
{
    public class _179
    {

        public string LargestNumber(int[] nums)
        {
            string[] strs = nums.Select(x => x.ToString()).ToArray();
            Array.Sort(strs, new  StringComparer());
            if (strs[0] == "0") return "0";
            return String.Join("", strs); ;
        }

        public class StringComparer : Comparer<string>
        {
            public override int Compare(string? x, string? y)
            {
                BigInteger xy = BigInteger.Parse(x + y);
                BigInteger yx = BigInteger.Parse(y + x);
                if (xy > yx)
                {
                    return 1;
                }
                else if (xy == yx) { return 0; }
                else
                {
                    return -1;
                }
            }
        }
    }
}
