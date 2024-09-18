using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy
{

    public class _884
    {
        public string[] UncommonFromSentences(string s1, string s2)
        {

            var split1 = s1.Split(' ');
            var split2 = s2.Split(' ');
            var list1 = new List<string>();
            var list2 = new List<string>();
            foreach (var split in split1)
            {
                if (!list1.Contains(split))
                {
                    list1.Add(split);
                    list2.Add(split);
                }
                else if (list1.Contains(split) && list2.Contains(split))
                {
                    list2.Remove(split);
                }
            }

            foreach (var split in split2)
            {
                if (!list1.Contains(split))
                {
                    list1.Add(split);
                    list2.Add(split);
                }
                else if (list1.Contains(split) && list2.Contains(split))
                {
                    list2.Remove(split);
                }
            }

            return list2.ToArray();
        }
    }
}
