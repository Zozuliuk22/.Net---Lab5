using GameSystem.Interfaces;
using GameSystem.Properties;

namespace GameSystem.MoveableStrategies
{
    public class FlyingStrategy : IMoveableStrategy
    {
        public string Move()
        {
            return GameTexts.Flying;
        }
    }
}
