using GameSystem.Interfaces;
using GameSystem.Characters;
using GameSystem.Enums;

namespace Application
{
    public class GameClient
    {

        public Character ChooseElf(string name)
        {
            var character = new Elf()
            {
                Name = name,
            };
            character.SetStrategy(Constants.Strategies[CharacterAction.Walk]);
            return character;
        }

        public Character ChooseHarpy(string name)
        {
            var character = new Harpy()
            {
                Name = name,
            };
            character.SetStrategy(Constants.Strategies[CharacterAction.Fly]);
            return character;
        }

        public Character ChooseOrc(string name)
        {
            var character = new Orc()
            {
                Name = name,
            };
            character.SetStrategy(Constants.Strategies[CharacterAction.Walk]);
            return character;
        }

        public Character ChooseTroll(string name)
        {
            var character = new Troll()
            {
                Name = name,
            };
            character.SetStrategy(Constants.Strategies[CharacterAction.Walk]);
            return character;
        }

        public Character ChooseVampire(string name)
        {
            var character = new Vampire()
            {
                Name = name,
            };
            character.SetStrategy(Constants.Strategies[CharacterAction.Walk]);
            return character;
        }



        public Character ChooseWitch(string name)
        {
            var character = new Witch()
            {
                Name = name,
            };
            character.SetStrategy(Constants.Strategies[CharacterAction.Walk]);
            return character;
        }

        public Character ChooseTimeKeeper(string name)
        {
            var character = new TimeKeeper()
            {
                Name = name,
            };
            character.SetStrategy(Constants.Strategies[CharacterAction.Walk]);
            return character;
        }

        public Character ChoosePegasus(string name)
        {
            var character = new Pegasus()
            {
                Name = name,
            };
            character.SetStrategy(Constants.Strategies[CharacterAction.Walk]);
            return character;
        }        
    }
}
