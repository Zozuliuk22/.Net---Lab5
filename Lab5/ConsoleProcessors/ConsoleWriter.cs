using GameSystem.Interfaces;
using System;

namespace Application.ConsoleProcessors
{
    public static class ConsoleWriter
    {
        public static void WriteLabel()
        {
            Console.WriteLine("IS-02 - Zozuliuk Viktor - Variant 6 \n");
        }

        public static void WriteMenuCharacters()
        {
            Console.WriteLine("Game includes next characters:");
            var menu = "1 - Elf\n" +
                "2 - Harpy\n" +
                "3 - Orc\n" +
                "4 - Pegasus\n" +
                "5 - Time Keeper\n" +
                "6 - Troll\n" +
                "7 - Vampire\n" +
                "8 - Witch\n";
            Console.WriteLine(menu);
        }

        public static void WriteCharacter(Character character)
        {
            Console.WriteLine(character);
            Console.WriteLine($"\t{character.Move()}");
        }
    }
}
