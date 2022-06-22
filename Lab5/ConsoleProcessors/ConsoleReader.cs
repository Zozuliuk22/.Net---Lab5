using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.ConsoleProcessors
{
    public static class ConsoleReader
    {
        private static List<ConsoleKey?> _keys = new()
        {
            ConsoleKey.W,
            ConsoleKey.F,
            ConsoleKey.E
        };

        public static ConsoleKey ReadConsoleKey()
        {
            Console.Write($"Please, choose the moving [W - walking / F - flying / E -end] : ");

            var key = Console.ReadKey().Key;

            Console.WriteLine();

            while (_keys.FirstOrDefault(k => k == key) is null)
            {
                Console.Write($"Please, choose the moving [W - walking / F - flying / E -end] : ");
                key = Console.ReadKey().Key;
                Console.WriteLine();
            }            

            return key;
        }

        public static int ReadNumber()
        {
            var answer = 0;

            Console.Write("Please, enter the character: ");

            var number = Console.ReadLine();

            while (!Int32.TryParse(number, out answer) || answer <= 0 || answer > 8)
            {
                Console.Write("Please, enter the character: ");
                number = Console.ReadLine();
            }

            return answer;
        }

        public static string ReadName()
        {
            Console.Write("Please, enter the name: ");
            return Console.ReadLine();
        }
    }
}
