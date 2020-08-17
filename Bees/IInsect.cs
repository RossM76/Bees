namespace Bees
{
    public interface IInsect
    {
        float Health { get; }
        void Damage(int percent);
        bool IsDead { get; }
        bool CanFly { get; }
    }
}
