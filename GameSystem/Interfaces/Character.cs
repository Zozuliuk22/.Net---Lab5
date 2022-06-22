using System.Text;

namespace GameSystem.Interfaces
{
    public abstract class Character
    {
        private IMoveableStrategy _strategy;

        public string Name { get; set; }

        public int Health { get; protected set; }

        public int Damage { get; protected set; }

        public void SetStrategy(IMoveableStrategy strategy)
        {
            _strategy = strategy;
        }

        public virtual string Move()
        {
            return _strategy.Move();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"\tI'm {Name}.");
            builder.AppendLine($"\tClass: {GetType().Name}");
            builder.AppendLine($"\tHealth: {Health}");
            builder.AppendLine($"\tDamage: {Damage}");
            return builder.ToString();
        }
    }
}
