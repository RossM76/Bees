namespace Bees
{
    /// <summary>
    /// Defines Bee default behaviour
    /// </summary>
    public abstract class Bee : IInsect
    {
        public float Health { get; private set; } = 100;

        public bool IsDead { get; private set;}

        public bool CanFly { get; private set; } 

        public BeeType BeeType { get; internal set; }

        public virtual void Damage(int percent)
        {
            if (IsDead) return;

            var percentage = (percent / Health) * 100;

            Health -= percentage;

            if (Health < 0) Health = 0f;
        }

        public void SetCanFly(bool canFly)
        {
            CanFly = canFly;
        }

        public void SetDead()
        {
            Health = 0f;
            IsDead = true;
            CanFly = false;
        }
    }
}
