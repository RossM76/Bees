namespace Bees
{
    public sealed class Queen : Bee
    {
        public Queen() => BeeType = BeeType.Queen;

        public override void Damage(int percent)
        {
            base.Damage(percent);

            if (Health < 20) SetDead();
        }
    }
}
