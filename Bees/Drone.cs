namespace Bees
{
    public sealed class Drone : Bee
    {
        public Drone() => BeeType = BeeType.Drone;

        public override void Damage(int percent)
        {
            base.Damage(percent);

            if (Health < 50) SetDead();
        }
    }
}
