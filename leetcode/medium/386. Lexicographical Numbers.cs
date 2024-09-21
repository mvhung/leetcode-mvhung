using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.medium
{
    public class _386
    {
        public IList<int> LexicalOrder(int n)
        {
            List<int> result = new List<int>();
            int scope = n > 9 ? 9 : n;
            for (int i = 1; i <= scope; i++)
            {
                result.Add(i);
                result.AddRange(recusive(i, n));
            }
            return result;
        }

        public List<int> recusive(int i, int n)
        {
            var res = new List<int>();



            int firstChildren = i * 10;
            int lastChildren = firstChildren + 9 <= n ? firstChildren + 9 : n;

            for (int j = firstChildren; j <= lastChildren; j++)
            {

                res.Add(j);
                if (j * 10 <= n)
                {
                    res.AddRange(recusive(j, n));
                }
            }
            return res;
        }
    }
}
