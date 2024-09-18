using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.medium
{
    public class _539
    {
        public int FindMinDifference(IList<string> timePoints)
        {

            List<string> lst = timePoints as List<string>;
            int min = 60 * 24;

            lst.Sort(Compare);

            for (int i = 0; i < lst.Count - 1; i++)
            {
                min = Math.Min(min, differentMinutes(lst[i], lst[i + 1]));
            }
            min = Math.Min(min, differentMinutes(lst[0], lst[lst.Count - 1]));
            return min;
        }
        public int differentMinutes(string t1, string t2)
        {
            var hm1 = t1.Split(':');
            var hm2 = t2.Split(':');
            int hour1 = int.Parse(hm1[0]);
            int hour2 = int.Parse(hm2[0]);

            int minute1 = int.Parse(hm1[1]);
            int minute2 = int.Parse(hm2[1]);

            int diff1 = (hour1 * 60 + minute1) - (hour2 * 60 + minute2);
            int diff2 = ((hour1 + 24) * 60 + minute1) - (hour2 * 60 + minute2);
            int diff3 = (hour1 * 60 + minute1) - ((hour2 + 24) * 60 + minute2);



            return Math.Min(Math.Min(Math.Abs(diff1), Math.Abs(diff2)), Math.Abs(diff3));
        }
        public int Compare(string t1, string t2)
        {
            var hm1 = t1.Split(':');
            var hm2 = t2.Split(':');
            int hour1 = int.Parse(hm1[0]);
            int hour2 = int.Parse(hm2[0]);

            int minute1 = int.Parse(hm1[1]);
            int minute2 = int.Parse(hm2[1]);

            if (hour1 > hour2 || (hour1 == hour2 && minute1 > minute2)) { return 1; }
            else if (hour1  == hour2 && minute1 == minute2)  { return 0; }
            else { return -1; }
        }
    }
}
