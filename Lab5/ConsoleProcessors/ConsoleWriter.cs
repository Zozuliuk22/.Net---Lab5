using Application.Properties;
using GameSystem.Interfaces;
using System;

namespace Application.ConsoleProcessors
{
    public static class ConsoleWriter
    {
        public static void WriteLabel()
        {
            Console.WriteLine($"{AppTexts.Label}\n");
        }

        public static void WriteMenuCharacters()
        {
            Console.WriteLine(AppTexts.MenuLabel);
            var menu = AppTexts.Menu.Split('\n');
            foreach (var item in menu)
                Console.WriteLine($"\t{item}");
            Console.WriteLine();
        }

        public static void WriteCharacter(Character character)
        {
            Console.WriteLine(character);
            Console.WriteLine($"\t{character.Move()}\n");
        }
    }
}
