using GameSystem.Enums;
using GameSystem.Interfaces;
using System.Collections.Generic;

namespace GameSystem.Characters
{
    public class Elf : Character
    {
        protected override void Initialize()
        {
            Health = 340;
            Damage = 90;
            HasMagic = false;
            PossibleActions = new List<CharacterAction>()
            {
                CharacterAction.Walk
            };
        }
    }
}
