using GameSystem.Enums;
using GameSystem.Interfaces;
using System.Collections.Generic;

namespace GameSystem.Characters
{
    public class Vampire : Character
    {
        protected override void Initialize()
        {
            Health = 450;
            Damage = 15;
            HasMagic = false;
            PossibleActions = new List<CharacterAction>()
            {
                CharacterAction.Walk
            };
        }
    }
}
