using GameSystem.Enums;
using GameSystem.Interfaces;
using System.Collections.Generic;

namespace GameSystem.Characters 
{ 
    public class Harpy : Character
    {
        protected override void Initialize()
        {
            Health = 860;
            Damage = 45;
            HasMagic = false;
            PossibleActions = new List<CharacterAction>()
            {
                CharacterAction.Fly
            };
        }
    }
}
