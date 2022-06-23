using Application.Properties;
using GameSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.ConsoleProcessors
{
    public static class ConsoleReader
    {
        private static Dictionary<ConsoleKey?, string> _keys = new()
        {
            { ConsoleKey.W, "walking" },
            { ConsoleKey.F, "flying" },
            { ConsoleKey.E, "end" }
        };

        public static ConsoleKey ReadConsoleKey()
        {
            foreach(var point in _keys)
                Console.WriteLine($"\t{point.Key} - {point.Value}");
            Console.WriteLine();

            Console.Write(AppTexts.ChooseMoving);

            var key = Console.ReadKey().Key;

            Console.WriteLine();

            while (!_keys.TryGetValue(key, out _))
            {
                Console.Write(AppTexts.ChooseMoving);
                key = Console.ReadKey().Key;
                Console.WriteLine();
            }            

            return key;
        }

        public static int ReadNumber()
        {
            var answer = 0;

            Console.Write(AppTexts.ChooseCharacter);

            var number = Console.ReadLine();

            while (!Int32.TryParse(number, out answer) || answer <= 0 || answer > 8)
            {
                Console.Write(AppTexts.ChooseCharacter);
                number = Console.ReadLine();
            }

            return answer;
        }

        public static string ReadName()
        {
            Console.Write(AppTexts.EnterName);
            return Console.ReadLine();
        }
    }
}
