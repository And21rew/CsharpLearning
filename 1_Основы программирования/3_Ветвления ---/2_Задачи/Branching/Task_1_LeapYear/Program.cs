﻿using System;

namespace Task_1_LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(2014));
            Console.WriteLine(IsLeapYear(1999));
            Console.WriteLine(IsLeapYear(8992));
            Console.WriteLine(IsLeapYear(1));
            Console.WriteLine(IsLeapYear(14));
            Console.WriteLine(IsLeapYear(400));
            Console.WriteLine(IsLeapYear(600));
            Console.WriteLine(IsLeapYear(3200));
        }

        public static bool IsLeapYear(int year)
        {
            return ((year % 400 == 0) || (year % 100 != 0)) && (year % 4 == 0);
        }
    }
}
