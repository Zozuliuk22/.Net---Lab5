using Application;
using Application.ConsoleProcessors;
using GameSystem.Interfaces;
using System;

namespace Lab5
{
    internal class Program
    {
        private static GameClient _gameClient;

        static void Main(string[] args)
        {
            ConsoleWriter.WriteLabel();

            _gameClient = new GameClient();

            while (true)
            {
                ConsoleWriter.WriteMenuCharacters();
                var answer = ConsoleReader.ReadNumber();
                var name = ConsoleReader.ReadName();
                Menu(answer, name);
            }
        }

        static void Menu(int answer, string name)
        {
            Character character;

            switch (answer)
            {
                case 1:
                    character = _gameClient.ChooseElf(name);
                    ConsoleWriter.WriteCharacter(character);
                    break;
                case 2:
                    character = _gameClient.ChooseHarpy(name);
                    ConsoleWriter.WriteCharacter(character);
                    break;
                case 3:
                    character = _gameClient.ChooseOrc(name);
                    ConsoleWriter.WriteCharacter(character);
                    break;
                case 4:
                    character = _gameClient.ChoosePegasus(name);
                    ConsoleWriter.WriteCharacter(character);
                    Play(character);
                    break;
                case 5:
                    character = _gameClient.ChooseTimeKeeper(name);
                    ConsoleWriter.WriteCharacter(character);
                    Play(character);
                    break;
                case 6:
                    character = _gameClient.ChooseTroll(name);
                    ConsoleWriter.WriteCharacter(character);
                    break;
                case 7:
                    character = _gameClient.ChooseVampire(name);
                    ConsoleWriter.WriteCharacter(character);
                    break;
                case 8:
                    character = _gameClient.ChooseWitch(name);
                    ConsoleWriter.WriteCharacter(character);
                    Play(character);
                    break;
            }            
        }

        static void Play(Character character)
        {
            var key = ConsoleReader.ReadConsoleKey();
            while (key != ConsoleKey.E)
            {
                _gameClient.ChangeMove(character, key);
                Console.WriteLine(character.Move());
                key = ConsoleReader.ReadConsoleKey();
            }
        }
    }
}
