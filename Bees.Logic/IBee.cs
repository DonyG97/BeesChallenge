namespace Bees.Logic
{
    public interface IBee
    {
        float Health { get; }

        bool IsDead { get; }

        int HealthThreshold { get; }

        void Damage(int damagePercentage);
    }
}