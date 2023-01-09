using System;

namespace Task_8_TheMainQuestionOfTheUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(GetSquare(42));
        }

        private static void Print(double number) =>
            Console.WriteLine(number.ToString());

        private static double GetSquare(double number) =>
            Math.Pow(number, 2);
    }
}
