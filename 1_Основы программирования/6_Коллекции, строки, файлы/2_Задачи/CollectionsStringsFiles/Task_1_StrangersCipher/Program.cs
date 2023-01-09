using System;
using System.Collections.Generic;

namespace Task_1_StrangersCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = new string[]
            {
                "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                "если особенно упорно подойдешь к делу",
                "",
                "будет Трудно конечнО",
                "Код ведЬ не из простых",
                "очень ХОРОШИЙ код",
                "то у тебя все получится",
                "и я буДу Писать тЕбЕ еще",
                "",
                "чао",
            };

            Console.WriteLine(DecodeMessage(message));
        }

        private static string DecodeMessage(string[] lines)
        {
            var result = new List<string>();

            for (int i = 0; i < lines.Length; i++)
                foreach (var word in lines[i].Split(' '))
                    if (lines[i] != "" && Char.IsUpper(word[0]))
                        result.Add(word);

            result.Reverse();

            return string.Join(" ", result.ToArray());
        }
    }
}
