using GameSystem.Enums;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Interfaces
{
    public abstract class Character
    {
        private IMoveableStrategy _strategy;

        public string Name { get; set; }

        public int Health { get; protected set; }

        public int Damage { get; protected set; }

        public bool HasMagic { get; protected set; }

        public List<CharacterAction> PossibleActions { get; protected set; } = new();

        public Character()
        {
            Initialize();
        }

        public void SetStrategy(IMoveableStrategy strategy)
        {
            _strategy = strategy;
        }

        public virtual string Move()
        {
            return _strategy.Move();
        }

        protected abstract void Initialize();

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine($"\tI'm {Name}.");
            builder.AppendLine($"\tClass: {GetType().Name}");
            builder.AppendLine($"\tHealth: {Health}");
            builder.AppendLine($"\tDamage: {Damage}");

            var magic = HasMagic ? "Yes" : "No";
            builder.AppendLine($"\tHas magic: {magic}");

            return builder.ToString();
        }
    }
}
