﻿using System;

namespace Task_6_NullOrNotNull
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(CheckFirstElement(null));
            Console.WriteLine(CheckFirstElement(new int[0]));
            Console.WriteLine(CheckFirstElement(new[] { 1 }));
            Console.WriteLine(CheckFirstElement(new[] { 0 }));
        }

        public static bool CheckFirstElement(int[] array)
        {
            return array != null && array.Length != 0 && array[0] == 0;
        }
    }
}
