using System;

namespace Task_1_MinimumFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }

        private static string GetMinX(double a, double b, double c)
        {
            if (a > 0)
                return (-b / (2 * a)).ToString();
            else if (a == 0 && b == 0)
                return c.ToString();
            else
                return "Impossible";
        }
    }
}
