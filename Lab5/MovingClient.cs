using GameSystem.Enums;
using GameSystem.Interfaces;

namespace Application
{
    public static class MovingClient
    {
        public static bool ChangeMove(this Character character, CharacterAction action)
        {
            var result = character.PossibleActions.Contains(action);

            if (result) 
                character.SetStrategy(Constants.Strategies[action]);

            return result;
        }
    }
}
