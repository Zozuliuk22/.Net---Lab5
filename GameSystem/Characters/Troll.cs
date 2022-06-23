using GameSystem.Enums;
using GameSystem.Interfaces;
using System.Collections.Generic;

namespace GameSystem.Characters
{
    public class Troll : Character
    {
        protected override void Initialize()
        {
            Health = 1560;
            Damage = 30;
            HasMagic = false;
            PossibleActions = new List<CharacterAction>()
            {
                CharacterAction.Walk
            };
        }
    }
}
