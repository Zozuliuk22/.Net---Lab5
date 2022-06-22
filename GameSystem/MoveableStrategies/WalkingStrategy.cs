using GameSystem.Interfaces;

namespace GameSystem.MoveableStrategies
{
    public class WalkingStrategy : IMoveableStrategy
    {
        public string Move()
        {
            return "I'm walking to my destination.";
        }
    }
}
