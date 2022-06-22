using GameSystem.Interfaces;

namespace GameSystem.MoveableStrategies
{
    public class FlyingStrategy : IMoveableStrategy
    {
        public string Move()
        {
            return "I'm flying to my destination.";
        }
    }
}
