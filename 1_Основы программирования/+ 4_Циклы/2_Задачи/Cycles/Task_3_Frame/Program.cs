using System;

namespace Task_3_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }

        private static void WriteTextWithBorder(string text)
        {
            Console.WriteLine("+" + new string('-', text.Length + 2) + "+");
            Console.WriteLine($"| {text} |");
            Console.WriteLine("+" + new string('-', text.Length + 2) + "+");
        }
    }
}
