using GameSystem.Enums;
using GameSystem.Interfaces;
using System.Collections.Generic;

namespace GameSystem.Characters
{
    public class Orc : Character
    {
        protected override void Initialize()
        {
            Health = 1430;
            Damage = 60;
            HasMagic = false;
            PossibleActions = new List<CharacterAction>()
            {
                CharacterAction.Walk
            };
        }
    }
}
