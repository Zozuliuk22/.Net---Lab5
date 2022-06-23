using GameSystem.Enums;
using GameSystem.Interfaces;
using System.Collections.Generic;

namespace GameSystem.Characters
{
    public class Pegasus : Character
    {
        protected override void Initialize()
        {
            Health = 1000;
            Damage = 40;
            HasMagic = false;
            PossibleActions = new List<CharacterAction>()
            {
                CharacterAction.Walk,
                CharacterAction.Fly
            };
        }
    }
}
