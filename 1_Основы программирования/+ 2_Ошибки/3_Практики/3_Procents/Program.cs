using System;

namespace Procents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate(Console.ReadLine());
        }

        public static double Calculate(string userInput)
        {
            var summa = double.Parse(userInput.Split()[0]);
            var mouthProcent = double.Parse(userInput.Split()[1]) / 12 / 100;
            var time = int.Parse(userInput.Split()[2]);

            return summa * Math.Pow((1 + mouthProcent), time);
        }
    }
}
