using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.medium
{
    public class _179
    {

        public string LargestNumber(int[] nums)
        {
            string[] strs = nums.Select(x => x.ToString() + ).ToArray();

            return "";
        }

        public class StringComparer : Comparer<string>
        {
            public override int Compare(string? x, string? y)
            {
                int xy = int.Parse(x + y);
                int yx = int.Parse(y + x);
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
