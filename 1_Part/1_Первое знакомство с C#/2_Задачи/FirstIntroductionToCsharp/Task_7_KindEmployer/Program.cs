using System;

namespace Task_7_KindEmployer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
        }

        private static string GetGreetingMessage(string name, double salary) => 
            $"Hello, {name}, your salary is {Math.Ceiling(salary)}";
    }
}
