using System;

namespace Task_1_InSearchOfThePowerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));
        }

        private static int GetMinPowerOfTwoLargerThan(int number)
        {
            int result = 1;
            while (number >= result)
                result *= 2;
            return result;
        }
    }
}
