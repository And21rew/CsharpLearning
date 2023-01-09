using System;

namespace Task_5_TarotCards
{
    internal class Program
    {
        enum Suits
        {
            Wands,
            Coins,
            Cups,
            Swords
        }

        public static void Main()
        {
            Console.WriteLine(GetSuit(Suits.Wands));
            Console.WriteLine(GetSuit(Suits.Coins));
            Console.WriteLine(GetSuit(Suits.Cups));
            Console.WriteLine(GetSuit(Suits.Swords));
        }

        private static string GetSuit(Suits suit)
        {
            return new[] { "жезлов", "монет", "кубков", "мечей" }[(int)suit];
        }
    }
}
