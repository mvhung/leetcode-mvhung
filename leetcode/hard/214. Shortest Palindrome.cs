using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.hard
{
    internal class _214
    {
        public string ShortestPalindrome(string s)
        {

            StringBuilder sb = new StringBuilder(s);
            string[] splitString = SplitString(s);
            string revertLeft = splitString[0];
            if (splitString[0] != splitString[1])
            {
                revertLeft = ReverseString(splitString[0]);
            }

            if (revertLeft == splitString[1]) return s;
            else
            {
                var p = s.Substring(s.Length - 1);
                return p + ShortestPalindrome(s.Substring(0, s.Length - 1)) + p;
            }

        }

        static string[] SplitString(string s)
        {
            int length = s.Length;
            int mid = length / 2;

            if (length % 2 == 0)
            {
                // Even length case
                return new string[] { s.Substring(0, mid), s.Substring(mid) };
            }
            else
            {
                // Odd length case, one part will be longer
                return new string[] { s.Substring(0, mid + 1), s.Substring(mid) };
            }
        }

        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
