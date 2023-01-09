using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_BenfordsLaw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(GetBenfordStatistics("1"));
            PrintNumbers(GetBenfordStatistics("abc"));
            PrintNumbers(GetBenfordStatistics("123 456 789"));
            PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
            PrintNumbers(GetBenfordStatistics(tallestBuildings));
        }

        public static int[] GetBenfordStatistics(string text)
        {
            var statistics = new int[10];
            for (int i = 0; i < text.Length; i++)
            {
                //...
            }
            return statistics;
        }
    }
}
