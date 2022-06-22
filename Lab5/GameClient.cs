using GameSystem.Interfaces;
using GameSystem.MoveableStrategies;
using GameSystem.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class GameClient
    {
        private Dictionary<ConsoleKey, IMoveableStrategy> _strategies = new()
        {
            { ConsoleKey.W, new WalkingStrategy() },
            { ConsoleKey.F, new FlyingStrategy() },
        };

        public Character ChooseElf(string name)
        {
            var character = new Elf()
            {
                Name = name,
            };
            character.SetStrategy(_strategies[ConsoleKey.W]);
            return character;
        }

        public Character ChooseHarpy(string name)
        {
            var character = new Harpy()
            {
                Name = name,
            };
            character.SetStrategy(_strategies[ConsoleKey.F]);
            return character;
        }

        public Character ChooseOrc(string name)
        {
            var character = new Orc()
            {
                Name = name,
            };
            character.SetStrategy(_strategies[ConsoleKey.W]);
            return character;
        }

        public Character ChooseTroll(string name)
        {
            var character = new Troll()
            {
                Name = name,
            };
            character.SetStrategy(_strategies[ConsoleKey.W]);
            return character;
        }

        public Character ChooseVampire(string name)
        {
            var character = new Vampire()
            {
                Name = name,
            };
            character.SetStrategy(_strategies[ConsoleKey.W]);
            return character;
        }



        public Character ChooseWitch(string name)
        {
            var character = new Witch()
            {
                Name = name,
            };
            character.SetStrategy(_strategies[ConsoleKey.W]);
            return character;
        }

        public Character ChooseTimeKeeper(string name)
        {
            var character = new TimeKeeper()
            {
                Name = name,
            };
            character.SetStrategy(_strategies[ConsoleKey.W]);
            return character;
        }

        public Character ChoosePegasus(string name)
        {
            var character = new Pegasus()
            {
                Name = name,
            };
            character.SetStrategy(_strategies[ConsoleKey.W]);
            return character;
        }


        public Character ChangeMove(Character character, ConsoleKey key)
        {
            character.SetStrategy(_strategies[key]);
            return character;
        }
    }
}
