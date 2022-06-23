using GameSystem.Interfaces;
using GameSystem.Properties;

namespace GameSystem.MoveableStrategies
{
    public class WalkingStrategy : IMoveableStrategy
    {
        public string Move()
        {
            return GameTexts.Walking;
        }
    }
}
