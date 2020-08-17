namespace Bees
{
    public sealed class Worker : Bee
    {
        public Worker() => BeeType = BeeType.Worker;

        public override void Damage(int percent)
        {
            base.Damage(percent);

            if (Health < 70) SetDead();
        }
    }
}
