using GameSystem.Enums;
using GameSystem.Interfaces;
using System.Collections.Generic;

namespace GameSystem.Characters
{
    public class Witch : Character
    {
        protected override void Initialize()
        {
            Health = 620;
            Damage = 60;
            HasMagic = true;
            PossibleActions = new List<CharacterAction>()
            {
                CharacterAction.Walk,
                CharacterAction.Fly
            };
        }
    }
}
