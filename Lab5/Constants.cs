using GameSystem.Enums;
using GameSystem.Interfaces;
using GameSystem.MoveableStrategies;
using System.Collections.Generic;
using System;

namespace Application
{
    public static class Constants
    {
        public static Dictionary<CharacterAction, IMoveableStrategy> Strategies = new()
        {
            { CharacterAction.Walk, new WalkingStrategy() },
            { CharacterAction.Fly, new FlyingStrategy() },
        };

        public static Dictionary<ConsoleKey, CharacterAction> KeyStrategies = new()
        {
            { ConsoleKey.W, CharacterAction.Walk },
            { ConsoleKey.F, CharacterAction.Fly },
        };
    }
}
