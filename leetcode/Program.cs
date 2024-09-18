using leetcode.medium;

namespace leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new _539();
            s.FindMinDifference(new List<string>
            {
                "10:32","14:55","13:03","15:52","15:05"
            });
            Console.WriteLine(s.ToString());
            Console.ReadLine();
        }
    }
}
