using GameSystem.Enums;
using GameSystem.Interfaces;
using System.Collections.Generic;

namespace GameSystem.Characters
{
    public class TimeKeeper : Character
    {
        protected override void Initialize()
        {
            Health = 100;
            Damage = 80;
            HasMagic = true;
            PossibleActions = new List<CharacterAction>()
            {
                CharacterAction.Walk,
                CharacterAction.Fly
            };
        }
    }
}
